using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace DataDrivenTestingWithApi
{
    public class Location
    {
        [JsonPropertyName("country abbreviation")]
        public string CountryAbbreviation { get; set; }

        [JsonPropertyName("post code")]
        public string PostCode { get; set; }

        [JsonPropertyName("places")]
        public Collection<Place> places { get; set; }
  
    }
}