using System.Text.Json.Serialization;

namespace frontend.Shared
{
    public class FlyerModel
    {
        [JsonPropertyName("flyerID")]
        public string flyerID { get; set; }

        [JsonPropertyName("supermarketID")]
        public string SupermarketID { get; set; }

        [JsonPropertyName("pageIndex")]
        public int PageIndex { get; set; }

        [JsonPropertyName("url")]
        public string ImageURL { get; set; }

        [JsonPropertyName("actualDate")]

        public string ActualDate { get; set; }
    }
}
