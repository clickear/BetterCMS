﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Category.Partial
{
    using System;
    using System.Collections.Generic;
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
    public partial class CategoryTreeTemplate : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Category.CategoryTreeNodeViewModel>
    {
        public CategoryTreeTemplate()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-navigation-categorynode-template\"");

WriteLiteral(">\r\n    <!-- ko if: !hasChildNodes() -->\r\n    <div class=\"bcms-nodes-dropzone bcms" +
"-nodes-dropzone-active\" data-bind=\"droppable: \'emptyListZone\'\">\r\n        <div cl" +
"ass=\"bcms-node-infotext\" data-bind=\"text: getNoDataMessage()\">");

            
            #line 7 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
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
             data-bind=""css: { 'bcms-nodes-dropzone-active': activeZone() == 'topZone'  }, droppable: 'topZone'"">
            <div class=""bcms-node-infotext"">");

            
            #line 16 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                       Write(RootGlobalization.CategoryTree_PlaceLinkHere_Message);

            
            #line default
            #line hidden
WriteLiteral(@"</div>
        </div>
        <!-- /ko -->
        <div data-bind=""draggable: $parentContext.$index, style: { zIndex: !isBeingDragged() ? '0' : '9999' }"">
            <div class=""bcms-placement-node"" data-bind=""
                        attr: { id: containerId },
                        css: { 'bcms-placement-node-drag': isBeingDragged(), 'bcms-placement-node-edit': isActive(), 'bcms-placement-one-active': !isBeingDragged() && superDraggable() },
                        style: { height: getNodeHeight() }"">
                <!-- ko if: hasChildNodes() -->
                <a class=""bcms-expand-collapse-node"" data-bind=""click: toggleExpand, css: { 'bcms-expanded-nodes': isExpanded() }"">&nbsp;</a>
                <!-- /ko -->
                <div class=""bcms-node-info"" data-bind=""droppable: 'middleZone'"">
                    <div class=""bcms-placement-title"" data-bind=""text: title""></div>
                </div>
                <!-- ko if: getCategoryTree().settings.canEditNode && isActive() -->
                <div class=""bcms-edit-node"">
                    <div class=""bcms-edit-node-holder"">
");

WriteLiteral("                        ");

            
            #line 33 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                   Write(Html.Tooltip(RootGlobalization.CategoryTree_NodeEdit_Title_Tooltip_Message));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div class=\"bcms-custom-input-box\" style=\"width: 50%;\">" +
"\r\n");

WriteLiteral("                            ");

            
            #line 35 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                       Write(Html.TextBoxFor(m => m.Title, new
                            {
                                data_bind = "value: title, valueUpdate: 'afterkeydown', enterPress: saveCategoryTreeNodeWithValidation, escPress: cancelEditCategoryTreeNode, hasfocus: isActive()",
                                @class = "bcms-editor-field-box",
                                Title = (string)null,
                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 41 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div class=\"bcms-btn-sm" +
"all\" data-bind=\"click: saveCategoryTreeNodeWithValidation, text: getCategoryTree" +
"().settings.nodeSaveButtonTitle\">");

            
            #line 43 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                                                                                                           Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div class=\"bcms-btn-links-small\" data-bind=\"clic" +
"k: cancelEditCategoryTreeNode\">");

            
            #line 44 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                                                   Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                    <!-- ko if: getCategoryTr" +
"ee().showMacros -->\r\n                    <div class=\"bcms-edit-node-holder\">\r\n");

WriteLiteral("                        ");

            
            #line 48 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                   Write(Html.Tooltip(RootGlobalization.CategoryTree_NodeEdit_Macro_Tooltip_Message));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div class=\"bcms-custom-input-box\" style=\"width: 100%;\"" +
">\r\n");

WriteLiteral("                            ");

            
            #line 50 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                       Write(Html.TextBoxFor(m => m.Macro, new
                            {
                                data_bind = "value: macro, valueUpdate: 'afterkeydown', enterPress: saveCategoryTreeNodeWithValidation, escPress: cancelEditCategoryTreeNode",
                                @class = "bcms-editor-field-box",
                                Title = (string)null,
                                placeholder = RootGlobalization.CategoryTree_NodeEdit_Macro_Placeholder_Message
                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 57 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
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

            
            #line 65 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                                                                     Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    <!-- /ko -->\r\n                    <!-- ko if: getCatego" +
"ryTree().settings.canDeleteNode -->\r\n                    <a class=\"bcms-icn-dele" +
"te\" data-bind=\"click: deleteCategoryTreeNode\">");

            
            #line 68 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
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

            
            #line 75 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
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
                            droppable: 'bottomZone'"">
                <div class=""bcms-node-infotext"">");

            
            #line 87 "..\..\Views\Category\Partial\CategoryTreeTemplate.cshtml"
                                           Write(RootGlobalization.CategoryTree_PlaceLinkHere_Message);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n            <!-- /ko -->\r\n        </div>\r\n    </div>\r" +
"\n    <!-- /ko -->\r\n    <!-- /ko -->\r\n</script>");

        }
    }
}
#pragma warning restore 1591
