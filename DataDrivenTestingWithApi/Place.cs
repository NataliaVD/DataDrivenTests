using System.Text.Json.Serialization;

namespace DataDrivenTestingWithApi
{
    public class Place
    {
        [JsonPropertyName("place name")]
        public string placeName;
    }
}