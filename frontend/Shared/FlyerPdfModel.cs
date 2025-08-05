using System.Text.Json.Serialization;

namespace frontend.Shared
{
    public class FlyerPdfModel
    {
        [JsonPropertyName("pdfID")]
        public string FlyerPdfID { get; set; }

        [JsonPropertyName("supermarketId")]
        public string SupermarketID {  get; set; }

        [JsonPropertyName("ActualDate")]
        public string ActualDate { get; set; }


        [JsonPropertyName("FirstPageURL")]
        public string FirstPageURL { get; set; }


        [JsonPropertyName("URL")]
        public string FlyerPdfURL { get; set; }
    }
}
