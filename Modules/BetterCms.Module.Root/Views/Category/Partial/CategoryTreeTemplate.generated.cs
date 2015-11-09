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
    
    #line 1 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Category/Partial/CategoryTreeTemplate.cshtml")]
    public partial class _Views_Category_Partial_CategoryTreeTemplate_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Category.CategoryTreeNodeViewModel>
    {
        public _Views_Category_Partial_CategoryTreeTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-navigation-categorynode-template\"");

WriteLiteral(">\n    <!-- ko if: !hasChildNodes() -->\n    <div class=\"bcms-nodes-dropzone bcms-n" +
"odes-dropzone-active\" data-bind=\"droppableCategoryNode: \'emptyListZone\'\">\n      " +
"  <div class=\"bcms-node-infotext\" data-bind=\"text: getNoDataMessage()\">");

            
            #line 8 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                        Write(RootGlobalization.CategoryTree_PlaceLinkHere_Message);

            
            #line default
            #line hidden
WriteLiteral(@"</div>
    </div>
    <!-- /ko -->
    <!-- ko foreach: childNodes -->
    <!-- ko if: isVisible() && !isDeleted() -->
    <div class=""bcms-tree-holder"">
        <!-- ko if: isFirstNode() -->
        <div class=""bcms-nodes-dropzone""
             data-bind=""css: { 'bcms-nodes-dropzone-active': activeZone() == 'topZone'  }, droppableCategoryNode: 'topZone'"">
            <div class=""bcms-node-infotext"">");

            
            #line 17 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                       Write(RootGlobalization.CategoryTree_PlaceLinkHere_Message);

            
            #line default
            #line hidden
WriteLiteral(@"</div>
        </div>
        <!-- /ko -->
        <div data-bind=""draggableCategoryNode: $parentContext.$index, style: { zIndex: !isBeingDragged() ? '0' : '9999' }"">
            <div class=""bcms-placement-node"" data-bind=""
                        attr: { id: containerId },
                        css: { 'bcms-placement-node-drag': isBeingDragged(), 'bcms-placement-node-edit': isActive(), 'bcms-placement-one-active': !isBeingDragged() && superDraggable() },
                        style: { height: getNodeHeight() }"">
                <!-- ko if: hasChildNodes() -->
                <a class=""bcms-expand-collapse-node"" data-bind=""click: toggleExpand, css: { 'bcms-expanded-nodes': isExpanded() }"">&nbsp;</a>
                <!-- /ko -->
                <div class=""bcms-node-info"" data-bind=""droppableCategoryNode: 'middleZone'"">
                    <div class=""bcms-placement-title"" data-bind=""text: title""></div>
                </div>
                <!-- ko if: getCategoryTree().settings.canEditNode && isActive() -->
                <div class=""bcms-edit-node"">
                    <div class=""bcms-edit-node-holder"">
");

WriteLiteral("                        ");

            
            #line 34 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                   Write(Html.Tooltip(RootGlobalization.CategoryTree_NodeEdit_Title_Tooltip_Message));

            
            #line default
            #line hidden
WriteLiteral("\n                        <div class=\"bcms-custom-input-box\" style=\"width: 50%;\">\n" +
"");

WriteLiteral("                            ");

            
            #line 36 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                       Write(Html.TextBoxFor(m => m.Title, new
                            {
                                data_bind = "value: title, valueUpdate: 'afterkeydown', enterPress: saveCategoryTreeNodeWithValidation, escPress: cancelEditCategoryTreeNode, hasfocus: isActive()",
                                @class = "bcms-editor-field-box",
                                Title = (string)null,
                            }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                            ");

            
            #line 42 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("\n                        </div>\n                        <div class=\"bcms-btn-smal" +
"l\" data-bind=\"click: saveCategoryTreeNodeWithValidation, text: getCategoryTree()" +
".settings.nodeSaveButtonTitle\">");

            
            #line 44 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                                                                                                           Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                        <div class=\"bcms-btn-links-small\" data-bind=\"click" +
": cancelEditCategoryTreeNode\">");

            
            #line 45 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                                                   Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    </div>\n                    <!-- ko if: getCategoryTree" +
"().showMacros -->\n                    <div class=\"bcms-edit-node-holder\">\n");

WriteLiteral("                        ");

            
            #line 49 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                   Write(Html.Tooltip(RootGlobalization.CategoryTree_NodeEdit_Macro_Tooltip_Message));

            
            #line default
            #line hidden
WriteLiteral("\n                        <div class=\"bcms-custom-input-box\" style=\"width: 100%;\">" +
"\n");

WriteLiteral("                            ");

            
            #line 51 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                       Write(Html.TextBoxFor(m => m.Macro, new
                            {
                                data_bind = "value: macro, valueUpdate: 'afterkeydown', enterPress: saveCategoryTreeNodeWithValidation, escPress: cancelEditCategoryTreeNode",
                                @class = "bcms-editor-field-box",
                                Title = (string)null,
                                placeholder = RootGlobalization.CategoryTree_NodeEdit_Macro_Placeholder_Message
                            }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Macro));

            
            #line default
            #line hidden
WriteLiteral(@"
                        </div>
                    </div>
                    <!-- /ko -->
                </div>
                <!-- /ko -->
                <div class=""bcms-node-controls"">
                    <!-- ko if: getCategoryTree().settings.canEditNode -->
                    <a class=""bcms-icn-edit"" data-bind=""click: startEditCategoryTreeNode"">");

            
            #line 66 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                                     Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\n                    <!-- /ko -->\n                    <!-- ko if: getCategory" +
"Tree().settings.canDeleteNode -->\n                    <a class=\"bcms-icn-delete\"" +
" data-bind=\"click: deleteCategoryTreeNode\">");

            
            #line 69 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                                    Write(RootGlobalization.Button_Delete);

            
            #line default
            #line hidden
WriteLiteral(@"</a>
                    <!-- /ko -->
                </div>
            </div>
            <!-- ko if: activeZone() == 'middleZone' -->
            <div class=""bcms-zone-holder"">
                <div class=""bcms-nodes-dropzone bcms-nodes-dropzone-active"">
                    <div class=""bcms-node-infotext"">");

            
            #line 76 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                               Write(RootGlobalization.CategoryTree_PlaceLinkHere_Message);

            
            #line default
            #line hidden
WriteLiteral(@"</div>
                </div>
            </div>
            <!-- /ko -->
            <!-- ko if: isExpanded() && hasChildNodes() -->
            <div class=""bcms-zone-holder"" data-bind=""template: { name: 'bcms-navigation-categorynode-template' }""></div>
            <!-- /ko -->
            <!-- ko if: !isBeingDragged() -->
            <div class=""bcms-nodes-dropzone""
                 data-bind=""css: { 'bcms-nodes-dropzone-active': activeZone() == 'bottomZone' },
                            style: { paddingBottom: !(parentNode().parentNode) && isLastNode() ? '80px' : '' },
                            droppableCategoryNode: 'bottomZone'"">
                <div class=""bcms-node-infotext"">");

            
            #line 88 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                           Write(RootGlobalization.CategoryTree_PlaceLinkHere_Message);

            
            #line default
            #line hidden
WriteLiteral("</div>\n            </div>\n            <!-- /ko -->\n        </div>\n    </div>\n    " +
"<!-- /ko -->\n    <!-- /ko -->\n</script>");

        }
    }
}
#pragma warning restore 1591
