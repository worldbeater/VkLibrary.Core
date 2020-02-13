using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemTopic
    {
        [JsonProperty("comments")]
        public BaseCommentsInfo Comments { get; set; }
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }

        ///<summary>
        /// Topic post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        ///<summary>
        /// Post text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
    }
}