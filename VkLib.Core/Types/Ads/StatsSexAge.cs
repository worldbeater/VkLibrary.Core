using Newtonsoft.Json;

namespace VkLib.Types.Ads
{
    public class StatsSexAge
    {
        /// <summary>
        ///     Sex and age interval
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        ///     Impressions rate
        /// </summary>
        [JsonProperty("impressions_rate")]
        public uint? ImpressionsRate { get; set; }

        /// <summary>
        ///     Clicks rate
        /// </summary>
        [JsonProperty("clicks_rate")]
        public uint? ClicksRate { get; set; }
    }
}