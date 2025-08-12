using System.Text.Json.Serialization;

namespace frontend.Shared
{
    public class FlyerModel
    {
        [JsonPropertyName("flyerID")]
        public string flyerID { get; set; } = string.Empty;

        [JsonPropertyName("supermarketID")]
        public string SupermarketID { get; set; } = string.Empty;

        [JsonPropertyName("pageIndex")]
        public int PageIndex { get; set; }

        [JsonPropertyName("ServiceType")]
        public string ServiceType { get; set; }

        [JsonPropertyName("url")]
        public string ImageURL { get; set; } = string.Empty;

        [JsonPropertyName("actualDate")]

        public string ActualDate { get; set; } = string.Empty;
    }
}
