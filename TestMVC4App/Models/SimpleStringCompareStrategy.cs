﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace TestMVC4App.Models
{
    public class SimpleStringCompareStrategy : CompareStrategy
    {
        private string oldValue = string.Empty;
        private string newValue = string.Empty;

        public SimpleStringCompareStrategy(string oldValue, string newValue, ResultReport resultReport) 
            : base (new List<string>() {oldValue}, new List<string>() {newValue}, resultReport)
        {
            if (!string.IsNullOrEmpty(oldValue))
            {
                this.oldValue = oldValue;
            }

            if (!string.IsNullOrEmpty(newValue))
            {
                this.newValue = newValue;
            }

            System.Diagnostics.Debug.WriteLine("Current Test is " + resultReport.TestDescription);
        }

        public override void Investigate()
        {
            // in some cases there is no need to run warning checks
            bool keepGoing = true;

            if (keepGoing)
            {
                keepGoing = AreBothValuesEmpty();
            }

            if (keepGoing)
            {
                keepGoing = AreBothValuesEqual();
            }

            if (keepGoing)
            {
                keepGoing = AreBothValuesEqualOnceTrimmed();
            }

            if (keepGoing)
            {
                keepGoing = DoesNewValueContainWhiteSpaceOnly();
            }

            if (keepGoing)
            {
                keepGoing = DoBothValuesHaveDifferentContent();
            }

            if (keepGoing)
            {
                keepGoing = MissingValueOnTheOldSide();
            }

            if (keepGoing)
            {
                keepGoing = MissingValueOnTheNewSide();
            }
        }

        #region Scenarios

        private bool AreBothValuesEmpty()
        {
            bool shouldContinueTesting = true;

            if(string.IsNullOrEmpty(oldValue) && string.IsNullOrEmpty(newValue))
            {
                this.resultReport.Observations.Add(IdentifiedDataBehavior.VALUES_NOT_POPULATED);
                this.resultReport.UpdateSeverityState(ResultSeverityState.WARNING);
                shouldContinueTesting = false;
            }
            else
            {
                this.resultReport.UpdateSeverityState(ResultSeverityState.SUCCESS);
            }

            return shouldContinueTesting;
        }

        private bool AreBothValuesEqual()
        {
            bool shouldContinueTesting = true;

            try
            {
                Assert.AreEqual(oldValue, newValue, this.resultReport.TestDescription);
                this.resultReport.UpdateSeverityState(ResultSeverityState.SUCCESS);
                shouldContinueTesting = false;

            }
            catch (AssertFailedException e)
            {
                this.resultReport.UpdateSeverityState(ResultSeverityState.ERROR);
                this.resultReport.ErrorMessage = CompareStrategy.ReplaceProblematicTagsForHtml(e.Message);
            }

            return shouldContinueTesting;
        }

        private bool AreBothValuesEqualOnceTrimmed()
        {
            bool shouldContinueTesting = true;

            if (oldValue.Trim() == newValue.Trim())
            {
                this.resultReport.Observations.Add(IdentifiedDataBehavior.MISMATCH_DUE_TO_TRAILING_WHITE_SPACES);
                this.resultReport.UpdateSeverityState(ResultSeverityState.ERROR_WITH_EXPLANATION);
                shouldContinueTesting = false;
            }

            return shouldContinueTesting;
        }

        private bool DoesNewValueContainWhiteSpaceOnly()
        {
            bool shouldContinueTesting = true;

            if (newValue == " ")
            {
                this.resultReport.Observations.Add(IdentifiedDataBehavior.VALUE_POPULATED_WITH_WHITE_SPACE_ON_NEW_SERVICE);
                this.resultReport.UpdateSeverityState(ResultSeverityState.WARNING);
            }

            return shouldContinueTesting;
        }

        private bool DoBothValuesHaveDifferentContent()
        {
            bool shouldContinueTesting = true;

            if (!string.IsNullOrEmpty(oldValue) && !string.IsNullOrEmpty(newValue))
            {
                this.resultReport.Observations.Add(IdentifiedDataBehavior.WRONG_VALUE);
                // it is set as warning only because it provides more explicit info on the error
                // the error has been logged already
                this.resultReport.UpdateSeverityState(ResultSeverityState.WARNING);
            }

            return shouldContinueTesting;
        }

        private bool MissingValueOnTheOldSide()
        {
            bool shouldContinueTesting = true;

            if (string.IsNullOrEmpty(oldValue) && !string.IsNullOrEmpty(newValue) && newValue != " ")
            {
                this.resultReport.Observations.Add(IdentifiedDataBehavior.MORE_VALUES_ON_NEW_SERVICE);
                this.resultReport.UpdateSeverityState(ResultSeverityState.WARNING);
            }

            return shouldContinueTesting;
        }

        private bool MissingValueOnTheNewSide()
        {
            bool shouldContinueTesting = true;

            if (!string.IsNullOrEmpty(oldValue) && string.IsNullOrEmpty(newValue) && newValue != " ")
            {
                this.resultReport.Observations.Add(IdentifiedDataBehavior.MISSING_VALUES_ON_NEW_SERVICE);
                this.resultReport.UpdateSeverityState(ResultSeverityState.WARNING);
            }

            return shouldContinueTesting;
        }

        #endregion
    }
}