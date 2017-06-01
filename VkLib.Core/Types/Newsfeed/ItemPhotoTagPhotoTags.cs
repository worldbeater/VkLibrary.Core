using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed
{
    public class ItemPhotoTagPhotoTags
    {
        /// <summary>
        ///     Tags number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<NewsfeedPhoto> Items { get; set; }
    }
}