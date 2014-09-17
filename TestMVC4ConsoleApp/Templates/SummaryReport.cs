﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TestMVC4App.Templates
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    using TestMVC4App.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class SummaryReport : SummaryReportBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<html>
<head>
<style>
.table_main {border:solid 2px darkgrey;border-collapse:collapse;}
.title {text-align: center;}
.th_main {padding: 10px;font-variant: small-caps;text-align: center;border-width:2px;border-color:darkgrey;border-style:solid;background-color: lightgrey;}
.td_main {padding: 10px;border-width:2px;border-color:darkgrey;border-style:solid;}
.warning {background-color: bisque;color:black;font-weight:bold;}
.warning_no_data {background-color: beige;color:black;font-weight:bold;}
.false_positive {background-color: green;color:white;font-weight:bold;}
.error {background-color: Red;color:white;font-weight:bold;}
.success {color:black;font-weight:bold;}
.error_with_explanation {background-color: orange;color:white;font-weight:bold;}
.error_data {color: white;font-weight: bold;background-color: red;font-size: 2em; text-align: center;}
</style>
</head>
<body>
	<h1 id=""top"" class=""title"">Summary Report</h1>
	<hr/>

	");
            
            #line 29 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 if(!string.IsNullOrEmpty(SummaryReportDataObject.ErrorHappened)) { 
	string message = "UNKNOWN ERROR(S) MAY MAKE THESE RESULTS INCONSISTENT/UNRELIABLE !";
	if (SummaryReportDataObject.ErrorHappened == "HTTP") { message = "PROBLEMS CONNECTING TO DATA SERVICES MAKE THESE RESULTS INCONSISTENT/UNRELIABLE !"; } 
            
            #line default
            #line hidden
            this.Write("\t <p class=\"error_data\">");
            
            #line 32 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(message));
            
            #line default
            #line hidden
            this.Write("<br/>");
            
            #line 32 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.ErrorMessage));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t <hr/>\r\n\t");
            
            #line 34 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t<h2>Overview</h2>\r\n\t<p>Total count of tests run : ");
            
            #line 37 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}",SummaryReportDataObject.CountTestsRun)));
            
            #line default
            #line hidden
            this.Write("<br/>\r\n\tCount of tests per user profile : ");
            
            #line 38 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}",SummaryReportDataObject.CountTestsPerUser)));
            
            #line default
            #line hidden
            this.Write("<br/>\r\n\tCount of user profiles tested : ");
            
            #line 39 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}",SummaryReportDataObject.CountProfilesTested)));
            
            #line default
            #line hidden
            this.Write("<br/>\r\n\tCount of user profiles ignored : ");
            
            #line 40 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}",SummaryReportDataObject.CountProfilesIgnored)));
            
            #line default
            #line hidden
            this.Write("<br/>\r\n\tCount of user profiles free from any kind of warning : ");
            
            #line 41 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}",SummaryReportDataObject.CountProfilesWithoutWarnings)));
            
            #line default
            #line hidden
            this.Write("<br/>\r\n\tDuration : ");
            
            #line 42 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.Duration.ToString("hh'h: 'mm'mn:'ss's:'FFFFFFF")));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t<p>Average Duration by User Profile : ");
            
            #line 43 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.AverageDurationPerProfile.ToString("hh'h: 'mm'mn:'ss's:'FFFFFFF")));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t<br/>\r\n\t<table class=\"table_main\">\r\n\t\t<tr>\r\n\t\t<th class=\"th_main\">Result</" +
                    "th>\r\n\t\t<th class=\"th_main\">Count</th>\r\n\t\t<th class=\"th_main\">Description</th>\r\n\t" +
                    "\t</tr>\r\n\t\t");
            
            #line 51 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 foreach (KeyValuePair<EnumResultSeverityType,int> countPerSeverity in SummaryReportDataObject.CountBySeverity) { 
            
            #line default
            #line hidden
            this.Write("\t\t<tr>\r\n\t\t\t");
            
            #line 53 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 switch (countPerSeverity.Key) {
			case EnumResultSeverityType.FALSE_POSITIVE : 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"false_positive td_main\">\r\n\t\t\t");
            
            #line 56 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
			case EnumResultSeverityType.WARNING:
			case EnumResultSeverityType.WARNING_ONLY_NEW: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"warning td_main\">\r\n\t\t\t");
            
            #line 60 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
			case EnumResultSeverityType.WARNING_NO_DATA: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"warning_no_data td_main\">\r\n\t\t\t");
            
            #line 63 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
			case EnumResultSeverityType.ERROR_WITH_EXPLANATION:
			case EnumResultSeverityType.ERROR_ONLY_OLD: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"error_with_explanation td_main\">\r\n\t\t\t");
            
            #line 67 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
			case EnumResultSeverityType.ERROR: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"error td_main\">\r\n\t\t\t");
            
            #line 70 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
			default: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"success td_main\">\r\n\t\t\t");
            
            #line 73 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
		} 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 75 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(countPerSeverity.Key));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t<td class=\"td_main\">");
            
            #line 76 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}",countPerSeverity.Value)));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t<td class=\"td_main\" style=\"color:darkgrey;\">");
            
            #line 77 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ParsingHelper.GetDescription(countPerSeverity.Key)));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t</tr>\r\n\t");
            
            #line 79 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t</table>\r\n\t<br/>\r\n\t<br/>\r\n\t<table class=\"table_main\">\r\n\t<tr>\r\n\t\t<th class=\"th_ma" +
                    "in\">Identified Data Behavior</th>\r\n\t\t<th class=\"th_main\">Count</th>\r\n\t</tr>\r\n\t");
            
            #line 88 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 var sortedDictionary = SummaryReportDataObject.CountByIdentifiedDataBehavior.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
	foreach (KeyValuePair<EnumIdentifiedDataBehavior,int> countPerIdentifiedDataBehavior in sortedDictionary) {
		if(countPerIdentifiedDataBehavior.Value > 0) { 
            
            #line default
            #line hidden
            this.Write("\t<tr>\r\n\t\t<td class=\"td_main\">");
            
            #line 92 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(LogManager.IdentifiedBehaviorsDescriptions[countPerIdentifiedDataBehavior.Key]));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t<td class=\"td_main\">");
            
            #line 93 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}", countPerIdentifiedDataBehavior.Value)));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t</tr>\r\n\t");
            
            #line 95 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("\t</table>\r\n\t<br/>\r\n\t<br/>\r\n\t<br/>\r\n\t<hr/>\r\n\t<h2>Overview By Test Name Per User Pr" +
                    "ofile</h2>\r\n\t<a href=\"");
            
            #line 102 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.FileByProfileLink));
            
            #line default
            #line hidden
            this.Write(@""">Go to Overview of Results by UPI</a>
	<br/>
	<hr/>
	<h2>Overview By Test Name</h2>
	<br/>
	<table class=""table_main"">
	<tr>
		<th class=""th_main"">Test Name</th>
		<th class=""th_main"">Overall Success</th>
		<th class=""th_main"">Result Severity</th>
		<th class=""th_main"">Observations</th>
		<th class=""th_main"">Sample Data</th>
		<th class=""th_main"">Average Duration</th>
		<th class=""th_main"">More Info</th>
	</tr>
	");
            
            #line 117 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 foreach (var testName in SummaryReportDataObject.TestNames) { 
            
            #line default
            #line hidden
            this.Write("\t<tr>\r\n\t\t<td class=\"td_main\">");
            
            #line 119 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(testName));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t<td class=\"th_main\">\r\n\t\t\t");
            
            #line 121 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.FrequencySuccess_ByTestName[testName].ToString("P")));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t</td>\r\n\t\t<td class=\"td_main\">\r\n\t\t\t<table class=\"table_main\">\r\n\t\t\t");
            
            #line 125 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 foreach (KeyValuePair<EnumResultSeverityType,int> countPerSeverity in SummaryReportDataObject.CountBySeverity_ByTestName[testName]) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t<tr>\r\n\t\t\t");
            
            #line 127 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 switch (countPerSeverity.Key) {
				case EnumResultSeverityType.FALSE_POSITIVE : 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<td class=\"false_positive td_main\">\r\n\t\t\t\t");
            
            #line 130 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
				case EnumResultSeverityType.WARNING:
				case EnumResultSeverityType.WARNING_ONLY_NEW: 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<td class=\"warning td_main\">\r\n\t\t\t\t");
            
            #line 134 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
				case EnumResultSeverityType.WARNING_NO_DATA: 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<td class=\"warning_no_data td_main\">\r\n\t\t\t\t");
            
            #line 137 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
				case EnumResultSeverityType.ERROR_WITH_EXPLANATION:
				case EnumResultSeverityType.ERROR_ONLY_OLD: 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<td class=\"error_with_explanation td_main\">\r\n\t\t\t\t");
            
            #line 141 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
				case EnumResultSeverityType.ERROR: 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<td class=\"error td_main\">\r\n\t\t\t\t");
            
            #line 144 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
				default: 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<td class=\"success td_main\">\r\n\t\t\t\t");
            
            #line 147 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 break;
			} 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t");
            
            #line 149 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(countPerSeverity.Key));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t<td class=\"td_main\">");
            
            #line 150 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}", countPerSeverity.Value)));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t<td class=\"td_main\">\r\n\t\t\t\t\t");
            
            #line 152 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 double frequency = (double)countPerSeverity.Value /(double) SummaryReportDataObject.CountProfilesTested;
					if (frequency > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t");
            
            #line 154 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(frequency.ToString("P")));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t");
            
            #line 155 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t");
            
            #line 158 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t</table>\r\n\t\t</td>\r\n\t\t<td class=\"td_main\">\r\n\t\t\t<table class=\"table_main\">\r\n\t\t\t\t" +
                    "<tr>\r\n\t\t\t\t\t<th class=\"th_main\">Identified Data Behavior</th>\r\n\t\t\t\t\t<th class=\"th" +
                    "_main\">Count</th>\r\n\t\t\t\t</tr>\r\n\t\t\t\t");
            
            #line 167 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 if(SummaryReportDataObject.CountByIdentifiedDataBehavior_ByTestName.ContainsKey(testName)) {
				var sortedDictionary2 =SummaryReportDataObject.CountByIdentifiedDataBehavior_ByTestName[testName].OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
				foreach (KeyValuePair<EnumIdentifiedDataBehavior,int> countPerIdentifiedDataBehavior in sortedDictionary2) {
					if(countPerIdentifiedDataBehavior.Value > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<tr>\r\n\t\t\t\t\t<td class=\"td_main\">");
            
            #line 172 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(LogManager.IdentifiedBehaviorsDescriptions[countPerIdentifiedDataBehavior.Key]));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t\t<td class=\"td_main\">");
            
            #line 173 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.Format("{0:0,0}", countPerIdentifiedDataBehavior.Value)));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t</tr>\r\n\t\t\t\t");
            
            #line 175 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } } } 
            
            #line default
            #line hidden
            this.Write("\t\t\t</table>\r\n\t\t</td>\r\n\t\t<td class=\"td_main\">\r\n\t\t\t");
            
            #line 179 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 if(SummaryReportDataObject.SampleData_ByTestName.ContainsKey(testName)) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 180 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.SampleData_ByTestName[testName]));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 181 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</td>\r\n\t\t<td class=\"td_main\">\r\n\t\t");
            
            #line 184 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 if(SummaryReportDataObject.AverageDuration_ByTestName.ContainsKey(testName)) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 185 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.AverageDuration_ByTestName[testName].ToString("hh'h: 'mm'mn:'ss's:'FFFFFFF")));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 186 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</td>\r\n\t\t<td class=\"td_main\">\r\n\t\t\t<a href=\"");
            
            #line 189 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(testName));
            
            #line default
            #line hidden
            
            #line 189 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SummaryReportDataObject.FileLinkEnd));
            
            #line default
            #line hidden
            this.Write("\">Test Details</a>\r\n\t\t</td>\r\n\t</tr>\r\n\t");
            
            #line 192 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t</table>\r\n</body>\r\n</html>\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4App\Templates\SummaryReport.tt"

private global::TestMVC4App.Templates.SharedSummaryReportData _SummaryReportDataObjectField;

/// <summary>
/// Access the SummaryReportDataObject parameter of the template.
/// </summary>
private global::TestMVC4App.Templates.SharedSummaryReportData SummaryReportDataObject
{
    get
    {
        return this._SummaryReportDataObjectField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool SummaryReportDataObjectValueAcquired = false;
if (this.Session.ContainsKey("SummaryReportDataObject"))
{
    this._SummaryReportDataObjectField = ((global::TestMVC4App.Templates.SharedSummaryReportData)(this.Session["SummaryReportDataObject"]));
    SummaryReportDataObjectValueAcquired = true;
}
if ((SummaryReportDataObjectValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("SummaryReportDataObject");
    if ((data != null))
    {
        this._SummaryReportDataObjectField = ((global::TestMVC4App.Templates.SharedSummaryReportData)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class SummaryReportBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}