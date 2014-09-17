﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using YSM.PMS.Service.Common.DataTransfer;

namespace TestMVC4App.Models
{
    public class TestUnitUserGeneralInfo : TestUnit
    {
        public override string newServiceURLExtensionBeginning
        {
            get { return "Users/"; }
        }

        public override string newServiceURLExtensionEnding
        {
            get { return "/GeneralInfo"; }
        }

        public TestUnitUserGeneralInfo(TestSuite parent) : base(parent)
        {

        }

        protected override void RunAllSingleTests()
        {
            var newServiceInfo = this.NewDataAccessor.GetUserGeneralInfoById(this.UserId);

            this.CompareAndLog_Test(EnumTestUnitNames.UserGeneralInfo_Bio, "Comparing Bio", this.UserId, this.Upi, this.OldDataNodes, EnumOldServiceFieldsAsKeys.biography.ToString(), newServiceInfo.Bio);
            UserGeneralInfo_Titles_Test(newServiceInfo);
            UserGeneralInfo_LanguageUsers_Test(newServiceInfo);
            UserGeneralInfo_AltLastName_Test(newServiceInfo);
            UserGeneralInfo_AltFirstName_Test(newServiceInfo);
            UserGeneralInfo_AltMiddleName_Test(newServiceInfo);
            UserGeneralInfo_AltSuffix_Test(newServiceInfo);
            UserGeneralInfo_AltMiddleNameDisplayed_Test(newServiceInfo);
            UserGeneralInfo_SuffixNames_Test(newServiceInfo);
            UserGeneralInfo_CountCVs_Test(newServiceInfo);
            UserGeneralInfo_Organizations_Test(newServiceInfo);

            ComputeOverallSeverity();
        }

        #region Field Comparison Tests

        private void UserGeneralInfo_AltLastName_Test(UserGeneralInfo newServiceData)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport(EnumTestUnitNames.UserGeneralInfo_AltLastName, "Comparing AltLastName (if needed)");

            string oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.lastname.ToString());
            var compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.LastName, resultReport);
            compareStrategy.Investigate();

            if(resultReport.Result != EnumResultSeverityType.SUCCESS)
            {
                resultReport.ResetForReTesting();

                oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.lastname.ToString());
                compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.AltLastName, resultReport);
                compareStrategy.Investigate();
            }

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(this.UserId,
                                              this.Upi,
                                              this.Container.BuildOldServiceFullURL(this.Upi),
                                              this.BuildNewServiceURL(this.Upi),
                                              resultReport);
        }

        private void UserGeneralInfo_AltFirstName_Test(UserGeneralInfo newServiceData)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport(EnumTestUnitNames.UserGeneralInfo_AltFirstName, "Comparing AltFirstName (if needed)");

            string oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.firstname.ToString());
            var compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.FirstName, resultReport);
            compareStrategy.Investigate();

            if (resultReport.Result != EnumResultSeverityType.SUCCESS)
            {
                resultReport.ResetForReTesting();

                oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.firstname.ToString());
                compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.AltFirstName, resultReport);
                compareStrategy.Investigate();
            }

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(this.UserId,
                                              this.Upi,
                                              this.Container.BuildOldServiceFullURL(this.Upi),
                                              this.BuildNewServiceURL(this.Upi),
                                              resultReport);
        }

        private void UserGeneralInfo_AltMiddleNameDisplayed_Test(UserGeneralInfo newServiceData)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport(EnumTestUnitNames.UserGeneralInfo_AltMiddleNameDisplayed, "Comparing AltMiddleNameDisplayed");

            string oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.MiddleName.ToString());
            var compareStrategy = new CompareStrategyContextSwitcher(string.IsNullOrEmpty(oldValue).ToString(), newServiceData.IsAltMiddleNameDisplayed.ToString(), resultReport);
            compareStrategy.Investigate();

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(this.UserId,
                                              this.Upi,
                                              this.Container.BuildOldServiceFullURL(this.Upi),
                                              this.BuildNewServiceURL(this.Upi),
                                              resultReport);
        }

        private void UserGeneralInfo_AltSuffix_Test(UserGeneralInfo newServiceData)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport(EnumTestUnitNames.UserGeneralInfo_AltSuffix, "Comparing AltSuffix (if needed)");

            string oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.Suffix.ToString());
            var compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.Suffix, resultReport);
            compareStrategy.Investigate();

            if (resultReport.Result != EnumResultSeverityType.SUCCESS)
            {
                resultReport.ResetForReTesting();

                oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.Suffix.ToString());
                compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.AltSuffix, resultReport);
                compareStrategy.Investigate();
            }

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(this.UserId,
                                              this.Upi,
                                              this.Container.BuildOldServiceFullURL(this.Upi),
                                              this.BuildNewServiceURL(this.Upi),
                                              resultReport);
        }

        private void UserGeneralInfo_AltMiddleName_Test(UserGeneralInfo newServiceData)
        {
            var watch = new Stopwatch();
            watch.Start();
            var resultReport = new ResultReport(EnumTestUnitNames.UserGeneralInfo_AltMiddleName, "Comparing AltMiddleName (if needed)");

            string oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.middle.ToString());
            if (string.IsNullOrEmpty(oldValue))
            {
                oldValue = "False";
            }
            var compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.MiddleName, resultReport);
            compareStrategy.Investigate();

            if (resultReport.Result != EnumResultSeverityType.SUCCESS)
            {
                resultReport.ResetForReTesting();

                oldValue = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.middle.ToString());
                compareStrategy = new CompareStrategyContextSwitcher(oldValue, newServiceData.AltMiddleName, resultReport);
                compareStrategy.Investigate();
            }

            watch.Stop();
            resultReport.Duration = watch.Elapsed;

            this.DetailedResults.Add(resultReport);

            LogManager.Instance.LogTestResult(this.UserId,
                                              this.Upi,
                                              this.Container.BuildOldServiceFullURL(this.Upi),
                                              this.BuildNewServiceURL(this.Upi),
                                              resultReport);
        }

        private void UserGeneralInfo_Titles_Test(UserGeneralInfo newServiceData)
        {
            HashSet<string> oldValues = ParsingHelper.ParseListSimpleValues(this.OldDataNodes, EnumOldServiceFieldsAsKeys.title.ToString(), EnumOldServiceFieldsAsKeys.titleName.ToString());

            HashSet<string> newValues = new HashSet<string>();
            if(newServiceData.Titles.Count() > 0)
            {
                foreach(var title in newServiceData.Titles)
                {
                    if (!string.IsNullOrEmpty(title.Name))
                    {
                        newValues.Add(title.Name);
                    }
                }
            }

            this.CompareAndLog_Test(EnumTestUnitNames.UserGeneralInfo_Titles, "Comparing Title(s)", this.UserId, this.Upi, oldValues, newValues);
        }

        private void UserGeneralInfo_CountCVs_Test(UserGeneralInfo newServiceData)
        {
            HashSet<string> oldValues = ParsingHelper.ParseListSimpleValues(this.OldDataNodes, EnumOldServiceFieldsAsKeys.cv.ToString(), EnumOldServiceFieldsAsKeys.fileName.ToString());
            string oldValue = oldValues.Count().ToString();

            string newValue = newServiceData.CVs.Count().ToString();

            this.CompareAndLog_Test(EnumTestUnitNames.UserGeneralInfo_CVs_Count, "Count CVs listed", this.UserId, this.Upi, oldValue, newValue);
        }

        private void UserGeneralInfo_SuffixNames_Test(UserGeneralInfo newServiceData)
        {
            string oldValuePart1 = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.degree.ToString());
            string oldValuePart2 = ParsingHelper.ParseSingleValue(this.OldDataNodes, EnumOldServiceFieldsAsKeys.professionalSuffix.ToString());

            HashSet<string> oldValues = ParsingHelper.StringToList(oldValuePart1, ',');
            oldValues = ParsingHelper.StringToList(oldValuePart2, ',', oldValues);
            
            HashSet<string> newValues = new HashSet<string>();
            if (newServiceData.Titles.Count() > 0)
            {
                foreach (var suffix in newServiceData.Suffixes)
                {
                    newValues.Add(suffix.Name);
                }
            }

            this.CompareAndLog_Test(EnumTestUnitNames.UserGeneralInfo_Suffixes, "Comparing SuffixNames", this.UserId, this.Upi, oldValues, newValues);
        }

        private void UserGeneralInfo_LanguageUsers_Test(UserGeneralInfo newServiceData)
        {
            var oldValues = ParsingHelper.ParseListSimpleValues(this.OldDataNodes, EnumOldServiceFieldsAsKeys.language.ToString(), EnumOldServiceFieldsAsKeys.languageName.ToString());

            var newValues = new HashSet<string>();
            if (newServiceData.LanguageUsers.Count() > 0)
            {
                foreach (var language in newServiceData.LanguageUsers)
                {
                    newValues.Add(language.LanguageName);
                }
            }

            this.CompareAndLog_Test(EnumTestUnitNames.UserGeneralInfo_Languages, "Comparing LanguageUser(s)", this.UserId, this.Upi, oldValues, newValues);
        }

        private void UserGeneralInfo_Organizations_Test(UserGeneralInfo newServiceData)
        {
            var departments = ParsingHelper.ParseListNodes(this.OldDataNodes,EnumOldServiceFieldsAsKeys.department.ToString());
            var departmentTree = ParsingHelper.ParseListNodes(this.OldDataNodes, EnumOldServiceFieldsAsKeys.treeDepartments.ToString());

            var organizationTest = new TestUnitUserOrganization(this.Container, this);
            this.Children.Add(organizationTest);

            organizationTest.ProvideData(this.UserId, 
                                                     this.Upi, 
                                                     departments,
                                                     departmentTree, 
                                                     newServiceData.Organizations);
            organizationTest.RunAllTests();
        }

        #endregion
    }
}