using System.Text.Json.Serialization;

namespace frontend.Shared
{
    public class FlyerPdfModel
    {
        public string FlyerPdfId { get; set; }

        public string SupermarketId {  get; set; }

        public string ActualDate { get; set; }

        public string FirstPageURL { get; set; }


        [JsonPropertyName("URL")]
        public string FlyerPdfURL { get; set; }
    }
}
