﻿using System.Runtime.Serialization;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.Root.Tags.Tag
{
    [Route("/tags/{TagId}", Verbs = "GET")]
    [Route("/tags/by-name/{TagName}", Verbs = "GET")]
    [DataContract]
    public class GetTagRequest : RequestBase<GetTagModel>, IReturn<GetTagResponse>
    {
        [DataMember]
        public System.Guid? TagId
        {
            get
            {
                return Data.TagId;
            }
            set
            {
                Data.TagId = value;
            }
        }
        
        [DataMember]
        public string TagName
        {
            get
            {
                return Data.TagName;
            }
            set
            {
                Data.TagName = value;
            }
        }
    }
}