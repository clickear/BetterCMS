﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Sitemap\Preview.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Sitemap\Preview.cshtml"
    using BetterCms.Module.Pages.ViewModels.Sitemap;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Sitemap/Preview.cshtml")]
    public partial class _Views_Sitemap_Preview_cshtml : System.Web.Mvc.WebViewPage<SitemapViewModel>
    {
        public _Views_Sitemap_Preview_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tree-filter-holder\"");

WriteLiteral(" data-bind=\"with: sitemap\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: showLanguages, with: language\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">Edit sitemap in language:</div>\r\n        <select");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" data-bind=\"options: languages, optionsText: \'value\', optionsValue: \'key\', value:" +
" languageId\"");

WriteLiteral("></select>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-expand-link-holder\"");

WriteLiteral(" ");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: expandAll\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Sitemap\Preview.cshtml"
                                                              Write(NavigationGlobalization.Sitemap_Button_ExpandAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: collapseAll\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Sitemap\Preview.cshtml"
                                                                Write(NavigationGlobalization.Sitemap_Button_CollapseAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n");

            
            #line 17 "..\..\Views\Sitemap\Preview.cshtml"
Write(Html.Partial("Partial/Sitemap", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 19 "..\..\Views\Sitemap\Preview.cshtml"
Write(Html.Partial("Partial/SitemapTemplate", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
