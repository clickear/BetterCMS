﻿using System;
using System.Web.Mvc;

using BetterCms.Core.Models;
using BetterCms.Module.Blog.Commands.GetBlogPost;
using BetterCms.Module.Blog.Commands.GetBlogPostList;
using BetterCms.Module.Blog.Commands.SaveBlogPost;
using BetterCms.Module.Blog.Content.Resources;
using BetterCms.Module.Blog.ViewModels.Blog;
using BetterCms.Module.Pages.Content.Resources;
using BetterCms.Module.Root.Mvc;
using BetterCms.Module.Root.Mvc.Grids.GridOptions;

namespace BetterCms.Module.Blog.Controllers
{
    public class BlogController : CmsControllerBase
    {
        public virtual ActionResult Index(SearchableGridOptions request)
        {
            var model = GetCommand<GetBlogPostListCommand>().ExecuteCommand(request ?? new SearchableGridOptions());
            return View(model);
        }

        [HttpGet]
        public virtual ActionResult CreateBlogPost(string parentPageUrl)
        {
            var model = GetCommand<GetBlogPostCommand>().ExecuteCommand(Guid.Empty);
            var view = RenderView("EditBlogPost", model);
            var success = false;
            if (model != null)
            {
                model.ParentPageUrl = parentPageUrl;
                success = true;
            }

            return ComboWireJson(success, view, model, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public virtual ActionResult EditBlogPost(string id)
        {
            var model = GetCommand<GetBlogPostCommand>().ExecuteCommand(id.ToGuidOrDefault());
            var view = RenderView("EditBlogPost", model);
            var success = model != null;
           
            return ComboWireJson(success, view, model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public virtual ActionResult SaveBlogPost(BlogPostViewModel model)
        {
            var response = GetCommand<SaveBlogPostCommand>().ExecuteCommand(model);
            if (response != null)
            {
                Messages.AddSuccess(BlogGlobalization.CreatePost_CreatedSuccessfully_Message);
            }
            return WireJson(response != null, response);
        }
    }
}
