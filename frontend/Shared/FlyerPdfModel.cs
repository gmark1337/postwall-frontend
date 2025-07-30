using System.Text.Json.Serialization;

namespace frontend.Shared
{
    public class FlyerPdfModel
    {
        [JsonPropertyName("FlyerPdfId")]
        public string FlyerPdfID { get; set; }

        [JsonPropertyName("SupermarketId")]
        public string SupermarketID {  get; set; }

        public string ActualDate { get; set; }

        public string FirstPageURL { get; set; }


        [JsonPropertyName("URL")]
        public string FlyerPdfURL { get; set; }
    }
}
