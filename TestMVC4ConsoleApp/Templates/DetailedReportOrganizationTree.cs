﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TestMVC4ConsoleApp.Templates
{
    using System.Linq;
    using System.Text;
    using TestMVC4App.Models;
    using HtmlDiff;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class DetailedReportOrganizationTree : DetailedReportOrganizationTreeBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<tr>\r\n\t<td class=\"td_main\"><b>");
            
            #line 10 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.TestDescription));
            
            #line default
            #line hidden
            this.Write("</b><br/>\r\n\t\t<a id=\"");
            
            #line 11 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.UPI));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 11 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.TestName));
            
            #line default
            #line hidden
            this.Write("</a>\r\n\t</td>\r\n\t");
            
            #line 13 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 switch (SharedDataObject.Result) {
		case EnumResultSeverityType.FALSE_POSITIVE : 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"td_main false_positive\">\r\n\t\t");
            
            #line 16 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 break;
		case EnumResultSeverityType.WARNING:
		case EnumResultSeverityType.WARNING_ONLY_NEW: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"td_main warning\">\r\n\t\t");
            
            #line 20 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 break;
		case EnumResultSeverityType.WARNING_NO_DATA: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"td_main warning_no_data\">\r\n\t\t");
            
            #line 23 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 break;
		case EnumResultSeverityType.ERROR_WITH_EXPLANATION:
		case EnumResultSeverityType.ERROR_ONLY_OLD: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"td_main error_with_explanation\">\r\n\t\t");
            
            #line 27 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 break;
		case EnumResultSeverityType.ERROR: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"td_main error\">\r\n\t\t");
            
            #line 30 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 break;
		default: 
            
            #line default
            #line hidden
            this.Write("\t\t<td class=\"td_main success\">\r\n\t\t");
            
            #line 33 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 break;
	} 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 35 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.Result));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t<td class=\"td_main\">\r\n\t\t<a href=\"");
            
            #line 37 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.OldUrl));
            
            #line default
            #line hidden
            this.Write("\">Profile data of UPI ");
            
            #line 37 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.UPI));
            
            #line default
            #line hidden
            this.Write("</a><br/>\r\n\t\t<a href=\"");
            
            #line 38 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.NewUrl));
            
            #line default
            #line hidden
            this.Write("\">User data of ID is ");
            
            #line 38 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.UserId));
            
            #line default
            #line hidden
            this.Write("</a>\r\n\t</td>\r\n\t<td class=\"td_main\">\r\n\t\t");
            
            #line 41 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.ErrorMessage));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t<br/><br/>\r\n\t\t<table class=\"table_main\">\r\n\t\t<tr>\r\n\t\t\t<td class=\"th_main\">OLD " +
                    "SERVICE DATA</td>\r\n\t\t\t<td class=\"th_main\">NEW SERVICE DATA</td>\r\n\t\t</tr>\r\n\t\t<tr>" +
                    "\r\n\t\t\t<td class=\"td_main\">\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t");
            
            #line 51 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(SharedDataObject.OldOrganizationValues.Count() > 0) {
					foreach (OrganizationTreeDescriptor element in SharedDataObject.OldOrganizationValues) {
						if (element.Depth < 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<li>[DEPTH NOT ASSIGNED] ");
            
            #line 54 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element.Name));
            
            #line default
            #line hidden
            this.Write(" (");
            
            #line 54 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element.ID));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t\t\t\t\t\t");
            
            #line 55 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsMissing) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"missing\">[MISSING IN NEW SERVICE]</span>");
            
            #line 55 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t");
            
            #line 56 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsDuplicate) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"duplicate\">[DUPLICATE]</span>");
            
            #line 56 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t");
            
            #line 58 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } } } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<br/><br/>\r\n\t\t\t\t\t");
            
            #line 60 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(SharedDataObject.OldTreeRoot != null) {
					var flattenedTree = new OrganizationTreeDescriptor[] { SharedDataObject.OldTreeRoot }.SelectNestedChildren(t => t.Children).ToList();
					foreach (OrganizationTreeDescriptor element in flattenedTree) {
						StringBuilder sb = new StringBuilder();
						sb.Append("[DEPTH " + element.Depth + "] ");
						for (int i = 0; i < element.Depth; i++) { sb.Append("- "); }
						if ((SharedDataObject.TreeComparisonIndexError > 0 && element.Depth == SharedDataObject.TreeComparisonIndexError) || element.IsImportedFromNewService || element.UsedMoreThanOnce || element.WasOnlyOption) { sb.Append("<span class=\"tree_depth_mismatch\">"); }
						sb.Append(element.Name + " (" + element.ID + ")");
						if (SharedDataObject.TreeComparisonIndexError > 0 && element.Depth == SharedDataObject.TreeComparisonIndexError) { sb.Append(" [DEPTH COUNT MISMATCH WITH NEW SERVICE]"); }
						if (element.IsImportedFromNewService) { sb.Append(" [IMPORTED FROM NEW SERVICE]"); }
						if (element.UsedMoreThanOnce) { sb.Append(" [USED MORE THAN ONCE]"); }
						if (element.WasOnlyOption) { sb.Append(" [ONLY OPTION]"); }
						if ((SharedDataObject.TreeComparisonIndexError > 0 && element.Depth == SharedDataObject.TreeComparisonIndexError) || element.IsImportedFromNewService || element.UsedMoreThanOnce || element.WasOnlyOption) { sb.Append("</span>"); } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<li>");
            
            #line 73 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sb));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t");
            
            #line 74 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsMissing) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"missing\">[MISSING IN NEW SERVICE]</span>");
            
            #line 74 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t");
            
            #line 75 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsDuplicate) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"duplicate\">[DUPLICATE]</span>");
            
            #line 75 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</li>\r\n\t\t\t\t\t");
            
            #line 77 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</ul>\r\n\t\t\t</td>\r\n\t\t\t<td class=\"td_main\">\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t");
            
            #line 82 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(SharedDataObject.NewOrganizationValues.Count() > 0) {
					foreach (OrganizationTreeDescriptor element in SharedDataObject.NewOrganizationValues) {
						if (element.Depth < 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<li>[DEPTH NOT ASSIGNED] ");
            
            #line 85 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element.Name));
            
            #line default
            #line hidden
            this.Write(" (");
            
            #line 85 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element.ID));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t\t\t\t\t\t");
            
            #line 86 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsMissing) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"missing\">[MISSING IN OLD SERVICE]</span>");
            
            #line 86 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t");
            
            #line 87 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsDuplicate) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"duplicate\">[DUPLICATE]</span>");
            
            #line 87 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t</li>");
            
            #line 88 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"

					} } } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<br/><br/>\r\n\t\t\t\t\t");
            
            #line 91 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if (SharedDataObject.NewTreeRoot != null) {
					var flattenedTree2 = new OrganizationTreeDescriptor[] { SharedDataObject.NewTreeRoot }.SelectNestedChildren(t => t.Children).ToList();
					foreach (OrganizationTreeDescriptor element in flattenedTree2) {
						StringBuilder sb = new StringBuilder();
						sb.Append("[DEPTH " + element.Depth + "] ");
						for (int i = 0; i < element.Depth; i++) { sb.Append("- "); }
						if (SharedDataObject.TreeComparisonIndexError > 0 && element.Depth == SharedDataObject.TreeComparisonIndexError) { sb.Append("<span class=\"tree_depth_mismatch\">"); }
						sb.Append(element.Name + " (" + element.ID + ")");
						if (SharedDataObject.TreeComparisonIndexError > 0 && element.Depth == SharedDataObject.TreeComparisonIndexError) { sb.Append(" [MISMATCH WITH OLD SERVICE]</span>"); }
						 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<li>");
            
            #line 101 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sb));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t");
            
            #line 102 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsMissing) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"missing\">[MISSING IN OLD SERVICE]</span>");
            
            #line 102 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t");
            
            #line 103 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(element.IsDuplicate) { 
            
            #line default
            #line hidden
            this.Write("<span class=\"duplicate\">[DUPLICATE]</span>");
            
            #line 103 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</li>\r\n\t\t\t\t\t");
            
            #line 105 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</ul>\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t</table>\r\n\t</td>\r\n\t<td class=\"td_main\">\r\n\t<p>Dura" +
                    "tion : ");
            
            #line 112 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SharedDataObject.Duration.ToString("mm'mn:'ss's:'FFFFFFF")));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t<br/>\r\n\t<ul>\r\n\t");
            
            #line 115 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 if(SharedDataObject.IdentifiedDataBehaviors != null) {
		foreach(var observation in SharedDataObject.IdentifiedDataBehaviors) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t<li>");
            
            #line 117 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(observation));
            
            #line default
            #line hidden
            this.Write("</li><br/>\r\n\t");
            
            #line 118 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("\t\t</ul>\r\n\t</td>\r\n</tr>");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "\\psf\Home\Desktop\TestMVC4App\Profile-System-Testing\TestMVC4ConsoleApp\Templates\DetailedReportOrganizationTree.tt"

private global::TestMVC4App.Templates.DetailedReportSharedData _SharedDataObjectField;

/// <summary>
/// Access the SharedDataObject parameter of the template.
/// </summary>
private global::TestMVC4App.Templates.DetailedReportSharedData SharedDataObject
{
    get
    {
        return this._SharedDataObjectField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool SharedDataObjectValueAcquired = false;
if (this.Session.ContainsKey("SharedDataObject"))
{
    this._SharedDataObjectField = ((global::TestMVC4App.Templates.DetailedReportSharedData)(this.Session["SharedDataObject"]));
    SharedDataObjectValueAcquired = true;
}
if ((SharedDataObjectValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("SharedDataObject");
    if ((data != null))
    {
        this._SharedDataObjectField = ((global::TestMVC4App.Templates.DetailedReportSharedData)(data));
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
    public class DetailedReportOrganizationTreeBase
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
