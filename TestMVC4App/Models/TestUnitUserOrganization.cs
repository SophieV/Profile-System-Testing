﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using YSM.PMS.Service.Common.DataTransfer;
using YSM.PMS.Web.Service.Clients;

namespace TestMVC4App.Models
{
    public class TestUnitUserOrganization : TestUnit
    {
        # region Data Provided by Parent Test Unit

        private IEnumerable<Organization> newServiceOrganizations = new HashSet<Organization>();
        private IEnumerable<XElement> oldServiceDepartments;
        private IEnumerable<XElement> oldServiceTreeDepartments;
        private HashSet<OrganizationTreeDescriptor> newServiceOrganizationDescriptors;
        private HashSet<OrganizationTreeDescriptor> oldServiceOrganizationDescriptors;
        private int userId;
        private int upi;

        public void ProvideOrganizationData(int userId,
                                            int upi,
                                            IEnumerable<XElement> oldServiceDepartments,
                                            IEnumerable<XElement> oldServiceTreeDepartments,
                                            IEnumerable<Organization> newServiceOrganizations)
        {
            this.userId = userId;
            this.upi = upi;

            if (newServiceOrganizations != null)
            {
                this.newServiceOrganizations = newServiceOrganizations;
            }

            if (oldServiceDepartments != null)
            {
                this.oldServiceDepartments = oldServiceDepartments;
            }

            if (oldServiceTreeDepartments != null)
            {
                this.oldServiceTreeDepartments = oldServiceTreeDepartments;
            }

            this.newServiceOrganizationDescriptors = new HashSet<OrganizationTreeDescriptor>();
            this.oldServiceOrganizationDescriptors = new HashSet<OrganizationTreeDescriptor>();
        }
        #endregion

        public override string newServiceURLExtensionBeginning
        {
            get { return Parent.newServiceURLExtensionBeginning; }
        }

        public override string newServiceURLExtensionEnding
        {
            get { return Parent.newServiceURLExtensionEnding; }
        }

        public TestUnitUserOrganization(TestSuite parent, TestUnit bigBrother) 
            : base (parent,bigBrother)
        {

        }

        protected override void RunAllSingleTests()
        {
            OrganizationTreeDescriptor oldTreeRoot = null;

            try 
            { 
                oldTreeRoot = ParseOldServiceData(); //.Children.First(); 
            } 
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
            }

            if (this.oldServiceOrganizationDescriptors.Count == 1)
            {
                // it means that there is only the root node, which is equivalent to no tree
                this.oldServiceOrganizationDescriptors.Clear();
            }

            OrganizationTreeDescriptor newTreeRoot = ParseNewServiceData();

            //Task[] tasks = new Task[2]
            //{
            //Task.Factory.StartNew(() => UserGeneralInfo_Organization_Id_Test(oldOrganizationIdValues, newOrganizationIdValues)),
            //Task.Factory.StartNew(() => UserGeneralInfo_Organization_Name_Test(oldOrganizationNameValues, newOrganizationNameValues))
            //};

            //Task.WaitAll(tasks);

            UserGeneralInfo_Organization_Id_Test(new HashSet<string>(this.oldServiceOrganizationDescriptors.Where(a => !string.IsNullOrEmpty(a.ID)).Select(a => a.ID)),
                                                 new HashSet<string>(this.newServiceOrganizationDescriptors.Where(a => !string.IsNullOrEmpty(a.ID)).Select(a => a.ID)));
            UserGeneralInfo_Organization_Name_Test(new HashSet<string>(this.oldServiceOrganizationDescriptors.Where(a => !string.IsNullOrEmpty(a.Name)).Select(a => a.Name)),
                                                   new HashSet<string>(this.newServiceOrganizationDescriptors.Where(a => !string.IsNullOrEmpty(a.Name)).Select(a => a.Name)));
            UserGeneralInfo_Organization_Type_Test(new HashSet<string>(this.newServiceOrganizationDescriptors.Where(a => !string.IsNullOrEmpty(a.Name)).Select(a => a.Type).Distinct()));
            UserGeneralInfo_Organization_IdAndNameTogether_Test(this.oldServiceOrganizationDescriptors,oldTreeRoot,this.newServiceOrganizationDescriptors,newTreeRoot);
            UserGeneralInfo_Organization_CheckTreeDepthCoherence_Test(this.oldServiceOrganizationDescriptors, this.newServiceOrganizationDescriptors, oldTreeRoot, newTreeRoot);
            UserGeneralInfo_Organization_CheckIsPrimary_Test(this.oldServiceOrganizationDescriptors, this.newServiceOrganizationDescriptors);
            UserGeneralInfo_Organization_MergingNewTreeToOldOne_Test(this.oldServiceOrganizationDescriptors, oldTreeRoot, this.newServiceOrganizationDescriptors, newTreeRoot);

            ComputeOverallSeverity();
        }

        #region Parsing Input Data

        private OrganizationTreeDescriptor ParseNewServiceData()
        {
            OrganizationTreeDescriptor root = null;
            OrganizationTreeDescriptor organizationDescriptor = null;

            if (this.newServiceOrganizations.Count() > 0)
            {
                foreach (var organization in this.newServiceOrganizations)
                {
                    organizationDescriptor = new OrganizationTreeDescriptor()
                    {
                        ID = organization.OrganizationId.ToString(),
                        Name = organization.Name,
                        IsPrimary = organization.IsImported,
                        ParentId = organization.OrganizationParentId.ToString(),
                        Type = organization.Type
                    };

                    this.newServiceOrganizationDescriptors.Add(organizationDescriptor);
                    organizationDescriptor = null;
                }

                LinkElementsOfOrganizationTree();

                root = this.newServiceOrganizationDescriptors.Where(z => z.Parent == null).First();

                AssignDepthProperty(root);
            }

            return root;
        }

        private void AssignDepthProperty(OrganizationTreeDescriptor treeOrganizationElement, int depth = 0)
        {
            treeOrganizationElement.Depth = depth;

            foreach (var child in treeOrganizationElement.Children)
            {
                AssignDepthProperty(child, depth + 1);
            }
        }

        private OrganizationTreeDescriptor ParseOldServiceData()
        {
            var rootContainer = new OrganizationTreeDescriptor();
            rootContainer.Depth = 0;
            this.oldServiceOrganizationDescriptors.Add(rootContainer);

            string parsedOrgId = string.Empty;
            string parsedOrgName = string.Empty;
            bool parsedIsPrimary = false;

            // first get the tree and its elements
            try
            {
                ParseRecursiveTree(this.oldServiceTreeDepartments.First(), rootContainer, this.oldServiceOrganizationDescriptors);
            }
            catch (Exception)
            {
                // there is no existing attribute to parse
            }

            // then try to complete the info about the elements of the tree
            // or add the elements separately to the list if not be found
            try
            {
                foreach (XElement el in oldServiceDepartments)
                {
                    try
                    {
                        parsedOrgId = el.Element("OrgID").Value;
                    }
                    catch (Exception)
                    {
                        // no value to parse
                        parsedOrgId = string.Empty;
                    }

                    try
                    {
                        parsedOrgName = el.Element("departmentName").Value;
                    }
                    catch (Exception)
                    {
                        // no value to parse
                        parsedOrgName = string.Empty;
                    }

                    try
                    {
                        string isPrimary = el.Element("primaryDept").Value.Trim();
                        if (isPrimary == "Y")
                        {
                             parsedIsPrimary = true;
                        }
                        else
                        {
                            parsedIsPrimary = false;
                        }
                    }
                    catch (Exception)
                    {
                        // no value to parse
                        parsedIsPrimary = false;
                    }

                    IEnumerable<OrganizationTreeDescriptor> findOrganizationResults = null;

                    if (!string.IsNullOrWhiteSpace(parsedOrgId))
                    {
                        findOrganizationResults = this.oldServiceOrganizationDescriptors.Where(i => i.ID == parsedOrgId);

                        if (findOrganizationResults == null || findOrganizationResults.Count() == 0)
                        {
                            findOrganizationResults = this.oldServiceOrganizationDescriptors.Where(i => i.Name == parsedOrgName && string.IsNullOrEmpty(i.ID));
                        }
                    }
                    else
                    {
                        findOrganizationResults = this.oldServiceOrganizationDescriptors.Where(i => i.Name == parsedOrgName);
                    }

                        if(findOrganizationResults.Count() == 0)
                        {
                            // was not found, create new one
                            var organizationDescriptor = new OrganizationTreeDescriptor() { ID = parsedOrgId, Name = parsedOrgName, IsPrimary = parsedIsPrimary };
                            this.oldServiceOrganizationDescriptors.Add(organizationDescriptor);
                        }
                        else if (findOrganizationResults.Count() == 1)
                        {
                            var organizationDescriptor = findOrganizationResults.First();

                            if (string.IsNullOrWhiteSpace(organizationDescriptor.ID))
                            {
                                organizationDescriptor.ID = parsedOrgId;
                            }

                            if (string.IsNullOrWhiteSpace(organizationDescriptor.Name))
                            {
                                organizationDescriptor.Name = parsedOrgName;
                            }

                            if (!organizationDescriptor.IsPrimary)
                            {
                                organizationDescriptor.IsPrimary = parsedIsPrimary;
                            }
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("More than one results returned for the unique organization. PROBLEM !");
                        }
                }
            }
            catch (Exception)
            {
                // there is no existing attribute to parse
            }

            return rootContainer;
        }

        private static void ParseRecursiveTree(XElement element, OrganizationTreeDescriptor parent, HashSet<OrganizationTreeDescriptor> allPuzzlePieces, int depth = 0)
        {
            OrganizationTreeDescriptor orgDesc = parent;

            if (element != null && element.Name == "treeDepartment") 
            {
                orgDesc = new OrganizationTreeDescriptor();

                try
                {
                    orgDesc.ID = element.Element("orgID").Value.Trim();
                }
                catch (Exception)
                {
                    // no value to parse
                }

                try
                {
                    orgDesc.Name = element.Element("name").Value.Trim();
                }
                catch (Exception)
                {
                    // no value to parse
                }

                try
                {
                    string isPrimary = element.Element("primaryDept").Value.Trim();
                    if(isPrimary == "Y")
                    {
                        orgDesc.IsPrimary = true;
                    }
                    else
                    {
                        orgDesc.IsPrimary = false;
                    }
                }
                catch (Exception)
                {
                    // no value to parse
                }

                if(depth > 0)
                {
                    orgDesc.Parent = parent;
                }

                orgDesc.Depth = depth;

                if(parent != null)
                {
                    parent.Children.Add(orgDesc);
                }

                allPuzzlePieces.Add(orgDesc);
        }

            if (element.Elements("treeDepartment").Count() > 0)
            {
                foreach (XElement child in element.Elements("treeDepartment"))
                {
                    ParseRecursiveTree(child, orgDesc, allPuzzlePieces, depth + 1);
                }
            }
        }

        private void LinkElementsOfOrganizationTree()
        {
            OrganizationTreeDescriptor potentialParent;
            var puzzlePiecesEnumerator = new List<OrganizationTreeDescriptor>();
            puzzlePiecesEnumerator.AddRange(this.newServiceOrganizationDescriptors);

            // get list of orphans
            List<OrganizationTreeDescriptor> orphans = new List<OrganizationTreeDescriptor>();

            // try to stitch pieces together
            foreach (var piece in puzzlePiecesEnumerator)
            {
                if (piece.Parent == null && !string.IsNullOrEmpty(piece.ParentId))
                {
                    try
                    {
                        potentialParent = puzzlePiecesEnumerator.Where(x => x.ID == piece.ParentId).First();
                    }
                    catch (Exception)
                    {
                        potentialParent = null;
                    }

                    if (potentialParent != null)
                    {
                        piece.Parent = potentialParent;
                        potentialParent.Children.Add(piece);
                    }
                    else
                    {
                        orphans.Add(piece);
                    }
                }
            }

            if (orphans.Count() > 0)
            {
                var organizationsClient = new OrganizationsClient();
                Organization downloadedParent;
                OrganizationTreeDescriptor downloadedParentDescriptor;

                foreach (string orphanParentId in orphans.Select(x=>x.ParentId).Distinct())
                {
                    System.Diagnostics.Debug.WriteLine("can't find parent " + orphanParentId);
                    downloadedParent = organizationsClient.GetOrganization(int.Parse(orphanParentId));
                    downloadedParentDescriptor = new OrganizationTreeDescriptor()
                    {
                        ID = downloadedParent.OrganizationId.ToString(),
                        Name = downloadedParent.Name,
                        IsPrimary = downloadedParent.IsImported,
                        ParentId = downloadedParent.OrganizationParentId.ToString(),
                        Parent = null
                    };
                    this.newServiceOrganizationDescriptors.Add(downloadedParentDescriptor);
                }

                LinkElementsOfOrganizationTree();
            }
        }

        #endregion

        #region Single Tests

        private void UserGeneralInfo_Organization_IdAndNameTogether_Test(HashSet<OrganizationTreeDescriptor> oldServiceOrganizationDescriptor, 
                                                                         OrganizationTreeDescriptor oldTreeRoot,
                                                                         HashSet<OrganizationTreeDescriptor> newServiceOrganizationDescriptor,
                                                                         OrganizationTreeDescriptor newTreeRoot)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport("UserGeneralInfo_Organization_IdAndNameTogether_Test", "Comparing Organization Id+Name Combinations");
            var compareStrategy = new CompareStrategyContextSwitcher(
                oldServiceOrganizationDescriptors,
                oldTreeRoot,
                newServiceOrganizationDescriptors,
                newTreeRoot,
                resultReport);
            compareStrategy.Investigate();

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(userId,
                                              upi,
                                              this.Master.BuildOldServiceFullURL(upi),
                                              this.BuildNewServiceFullURL(userId),
                                              resultReport);
        }

        private void UserGeneralInfo_Organization_Id_Test(HashSet<string> oldValues, HashSet<string> newValues)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport("UserGeneralInfo_Organization_Id_Test", "Comparing Organization Ids");
            var compareStrategy = new CompareStrategyContextSwitcher(oldValues, newValues, resultReport);
            compareStrategy.Investigate();

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(userId,
                                              upi,
                                              this.Master.BuildOldServiceFullURL(upi),
                                              this.BuildNewServiceFullURL(userId),
                                              resultReport);
        }

        private void UserGeneralInfo_Organization_Name_Test(HashSet<string> oldValues, HashSet<string> newValues)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport("UserGeneralInfo_Organization_Name_Test", "Comparing Organization Names");
            var compareStrategy = new CompareStrategyContextSwitcher(oldValues, newValues, resultReport);
            compareStrategy.Investigate();

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(userId,
                                              upi,
                                              this.Master.BuildOldServiceFullURL(upi),
                                              this.BuildNewServiceFullURL(userId),
                                              resultReport);
        }

        private void UserGeneralInfo_Organization_Type_Test(HashSet<string> newValues)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport("UserGeneralInfo_Organization_Type_Test", "Comparing Organization Types");

            if (newValues.Count() > 0)
            {
                var compareStrategy = new CompareStrategyContextSwitcher(new HashSet<string>() { "Academic Department" }, newValues, resultReport);
                compareStrategy.Investigate();
            }
            else
            {
                resultReport.UpdateResult(ResultSeverityType.WARNING_NO_DATA);
            }

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(userId,
                                              upi,
                                              this.Master.BuildOldServiceFullURL(upi),
                                              this.BuildNewServiceFullURL(userId),
                                              resultReport);
        }

        private void UserGeneralInfo_Organization_CheckTreeDepthCoherence_Test(HashSet<OrganizationTreeDescriptor> oldTree, HashSet<OrganizationTreeDescriptor> newTree, OrganizationTreeDescriptor oldTreeRoot, OrganizationTreeDescriptor newTreeRoot)
        {
            bool keepGoing = true;
            int index = 0;
            IEnumerable<OrganizationTreeDescriptor> oldEntriesSameDepth;
            IEnumerable<OrganizationTreeDescriptor> newEntriesSameDepth;
            int oldCount;
            int newCount;

            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport("UserGeneralInfo_Organization_CheckTreeDepthCoherence_Test", "Comparing Organization Tree Depth Coherence");

            while (keepGoing)
            {
                oldEntriesSameDepth = oldTree.Where(x => x.Depth == index);
                newEntriesSameDepth = newTree.Where(s => s.Depth == index);

                oldCount = oldEntriesSameDepth.Count();
                newCount = newEntriesSameDepth.Count();

                if (oldCount == 0 && newCount == 0)
                {
                    keepGoing = false;
                }

                try
                {
                    // the only we can compare is that the old tree does not return more entries than the new one at a given depth of depth
                    // the new service may return more because it has enriched the old tree where some of the values may have been manually - ? - excluded
                    Assert.IsFalse(oldCount > newCount, "Comparing at depth index " + index);

                    resultReport.UpdateResult(ResultSeverityType.SUCCESS);
                }
                catch (AssertFailedException e)
                {
                    resultReport.UpdateResult(ResultSeverityType.ERROR);
                    resultReport.ErrorMessage = e.Message;
                    resultReport.IdentifedDataBehaviors.Add(IdentifiedDataBehavior.OLD_TREE_HAS_MORE_CHILDREN_GIVEN_DEPTH);
                    resultReport.AddDetailedValues(oldTree, oldTreeRoot, newTree, newTreeRoot);
                    resultReport.TreeComparisonIndexError = index;

                    if (resultReport.Result == ResultSeverityType.ERROR)
                    {
                        keepGoing = false;
                    }
                }

                index++;
            }

            if(resultReport.Result == ResultSeverityType.SUCCESS)
            {
                resultReport.IdentifedDataBehaviors.Add(IdentifiedDataBehavior.NEW_TREE_COUNT_CONSISTENT);
                resultReport.AddDetailedValues(oldTree, oldTreeRoot, newTree, newTreeRoot);
            }

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(userId,
                                              upi,
                                              this.Master.BuildOldServiceFullURL(upi),
                                              this.BuildNewServiceFullURL(userId),
                                              resultReport);
        }

        private void UserGeneralInfo_Organization_CheckIsPrimary_Test(HashSet<OrganizationTreeDescriptor> oldTree, HashSet<OrganizationTreeDescriptor> newTree)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport("UserGeneralInfo_Organization_CheckIsPrimary_Test", "Comparing Organization IsImported/Primary");

            var oldEntriesIsPrimary = new HashSet<string>();
            var newEntriesIsPrimary = new HashSet<string>();

            try
            {
                oldEntriesIsPrimary = new HashSet<string>(oldTree.Where(x => x.IsPrimary == true).Select(x => x.Name));
            } 
            catch(Exception)
            {

            }

            try
            {
                newEntriesIsPrimary = new HashSet<string>(newTree.Where(s => s.IsPrimary == true).Select(x => x.Name));
            }
            catch (Exception)
            {

            }

            // this comparison can work because all the primary departments have a name assigned in the old service ! NOPE because the name may change...
            var collectionComparison = new CompareStrategyContextSwitcher(oldEntriesIsPrimary, newEntriesIsPrimary, resultReport);
            collectionComparison.Investigate();

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(userId,
                                              upi,
                                              this.Master.BuildOldServiceFullURL(upi),
                                              this.BuildNewServiceFullURL(userId),
                                              resultReport);
        }

        private void UserGeneralInfo_Organization_MergingNewTreeToOldOne_Test(HashSet<OrganizationTreeDescriptor> oldTree, OrganizationTreeDescriptor oldTreeRoot, HashSet<OrganizationTreeDescriptor> newTree, OrganizationTreeDescriptor newTreeRoot)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport("UserGeneralInfo_Organization_MergingNewTreeToOldOne_Test", "Trying to merge Organization Trees together");

            FillGapsOfTree(-1, oldTree, newTree);

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            var missingOldElementsWithChildAndParentAgain = oldTree.Where(x => x.HasBeenMatched == false && string.IsNullOrEmpty(x.ID) && string.IsNullOrEmpty(x.Name)).GroupBy(x => x.Depth).ToDictionary(t => t.Key, t => t.ToList());
            int countLeft = missingOldElementsWithChildAndParentAgain.Count();

            if (countLeft > 0)
            {
                // maybe a change of name ?
                // oldTree.Where(z => z.HasBeenMatched == false && z.IsMissing == true && string.IsNullOrEmpty(z.ID)).ToList().ForEach(z => { z.Name = string.Empty; });
                // FillGapsOfTree(countLeft, oldTree, newTree);

                // go through children to find parent of matched item
                // if the item is "hasbeenmatched == true" then use it and raise flag "usedmorethanonce" and add appropriate data behavior description

                // if immediate child does not have matched item, try searching for it without same depth
                // if works same as before but instead of "usedmorethanonce" then data behavior depth has been changed
            }

            countLeft = missingOldElementsWithChildAndParentAgain.Count();

            if (countLeft > 0)
            {
                // maybe a change of structure ? navigate to closest nodes to find ancre points
            }
            
            if (countLeft == 0)
            {
                resultReport.UpdateResult(ResultSeverityType.FALSE_POSITIVE);
            }
            else
            {
                resultReport.UpdateResult(ResultSeverityType.ERROR);
            }

            resultReport.AddDetailedValues(null, oldTree.Where(x=>x.Depth == 0).First(), null, null);

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(userId,
                                              upi,
                                              this.Master.BuildOldServiceFullURL(upi),
                                              this.BuildNewServiceFullURL(userId),
                                              resultReport);
        }

        private static void FillGapsOfTree(int previousCount, HashSet<OrganizationTreeDescriptor> oldTree,HashSet<OrganizationTreeDescriptor> newTree)
        {
            var missingOldElementsWithChildAndParent = oldTree.Where(x => x.HasBeenMatched == false && string.IsNullOrEmpty(x.ID) && string.IsNullOrEmpty(x.Name) && x.Depth >= 0).GroupBy(x => x.Depth).ToDictionary(t => t.Key, t => t.ToList());
            var potentialMatches = newTree.Where(x => x.HasBeenMatched == false).GroupBy(g => g.Depth).ToDictionary(t => t.Key, t => t.ToList());
            var missingOldElementsWithChildAndParentAgain = oldTree.Where(x => x.HasBeenMatched == false && string.IsNullOrEmpty(x.ID) && string.IsNullOrEmpty(x.Name)).GroupBy(x => x.Depth).ToDictionary(t => t.Key, t => t.ToList());

            int newCount = missingOldElementsWithChildAndParentAgain.Select(x => x.Value).Count();
            if (newCount > 0
                && potentialMatches.Select(x => x.Value).Count() > 0
                && newCount != previousCount)
            {
                foreach (var missingPair in missingOldElementsWithChildAndParent)
                {
                    foreach (var missing in missingPair.Value)
                    {
                        if (potentialMatches.ContainsKey(missingPair.Key))
                        {
                            foreach (var potential in potentialMatches[missingPair.Key])
                            {
                                // if there is only one potential match, don't be picky
                                if (potentialMatches[missingPair.Key].Count() == 1||(potential.ParentId == missing.ParentId || potential.Children.Count() >= missing.Children.Count()))
                                {
                                    int countLeft = 1;

                                    if (potential.Children.Select(x=>x.MatchedPartner).Count() > 0)
                                    {
                                        countLeft = missing.Children.Except(potential.Children.Select(x => x.MatchedPartner).Union(potential.Children)).Count();
                                    }
                                    else
                                    {
                                        var childrenIdsNew = potential.Children.Select(x => x.ID);
                                        var childrenIdsOld = missing.Children.Select(y => y.ID);

                                        countLeft = childrenIdsOld.Except(childrenIdsNew).Count();
                                    }

                                    if (potentialMatches[missingPair.Key].Count() == 1 || countLeft == 0)
                                    {
                                        potential.HasBeenMatched = true;
                                        potential.MatchedPartner = missing;
                                        missing.HasBeenMatched = true;
                                        missing.MatchedPartner = potential;
                                        potential.IsImportedFromNewService = true;
                                        missing.IsMissing = false;
                                        potential.IsMissing = false;

                                        potential.Children.Clear();
                                        potential.Parent = missing.Parent;

                                        // replace in old tree
                                        foreach (var childFromMissing in missing.Children)
                                        {
                                            childFromMissing.Parent = potential;
                                            potential.Children.Add(childFromMissing);
                                        }

                                        if (missing.Parent != null && missing.Parent.Children != null)
                                        {
                                            missing.Parent.Children.Add(potential);
                                            missing.Parent.Children.Remove(missing);
                                        }

                                        oldTree.Add(potential);
                                        oldTree.Remove(missing);
                                    }
                                }
                            }
                        }
                    }
                }

                FillGapsOfTree(newCount, oldTree, newTree);
            }
        }
    }

    #endregion
}