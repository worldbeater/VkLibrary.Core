using Newtonsoft.Json;

namespace VkLib.Types.Photos
{
    public class PhotoXtrRealOffset : Photo
    {
        /// <summary>
        ///     Real position of the photo
        /// </summary>
        [JsonProperty("real_offset")]
        public int? RealOffset { get; set; }

        /// <summary>
        ///     Returns if the photo is hidden above the wall
        /// </summary>
        [JsonProperty("hidden")]
        public string Hidden { get; set; }
    }
}