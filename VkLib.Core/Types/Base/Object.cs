using Newtonsoft.Json;

namespace VkLib.Types.Base
{
    public class Object
    {
        /// <summary>
        ///     Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Object title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}