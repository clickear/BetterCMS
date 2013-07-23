﻿using System.Runtime.Serialization;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.Blog.BlogPosts.BlogPost
{
    [Route("/blog-posts/{BlogPostId}", Verbs = "GET")]
    [DataContract]
    public class GetBlogPostRequest : RequestBase<GetBlogPostModel>, IReturn<GetBlogPostResponse>
    {
        [DataMember]
        public System.Guid BlogPostId
        {
            get
            {
                return Data.BlogPostId;
            }
            set
            {
                Data.BlogPostId = value;
            }
        }
    }
}