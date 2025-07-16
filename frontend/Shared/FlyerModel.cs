using System.Text.Json.Serialization;

namespace frontend.Shared
{
    public class FlyerModel
    {
        public string flyerID { get; set; }

        public string SupermarketID { get; set; }

        [JsonPropertyName("pageIndex")]
        public int PageIndex { get; set; }

        [JsonPropertyName("url")]
        public string ImageURL { get; set; }

        public string ActualDate { get; set; }
    }
}
