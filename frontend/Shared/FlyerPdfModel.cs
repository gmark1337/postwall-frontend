using System.Text.Json.Serialization;

namespace frontend.Shared
{
    public class FlyerPdfModel
    {
        [JsonPropertyName("pdfID")]
        public string FlyerPdfID { get; set; } = string.Empty;

        [JsonPropertyName("supermarketId")]
        public string SupermarketID { get; set; } = string.Empty;

        [JsonPropertyName("ActualDate")]
        public string ActualDate { get; set; } = string.Empty;


        [JsonPropertyName("FirstPageURL")]
        public string FirstPageURL { get; set; } = string.Empty;


        [JsonPropertyName("URL")]
        public string FlyerPdfURL { get; set; } = string.Empty;
    }
}
