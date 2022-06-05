using RestSharp;
using RestSharp.Serializers.Json;

namespace DataDrivenTestingWithApi
{

    public class ApiTests
    {
        public RestClient client;
        public RestRequest request;

        [SetUp]
        public void Setup()
        {
            this.client = new RestClient("http://api.zippopotam.us");
        }

        [TestCase("BG", "1000", "Sofija")]
        [TestCase("BG", "5980", "Cherven Briag")]
        [TestCase("CA", "M5S", "Toronto")]
        [TestCase("GB", "B1", "Birmingham")]
        [TestCase("DE", "01067", "Drezden")]

        public async Task TestZippopotam(string countryCode, string zipCode, string city)
        {
            request = new RestRequest(countryCode + "/" +zipCode);
            var response = await client.ExecuteAsync(request, Method.Get);

            var location = new SystemTextJsonSerializer().Deserialize<Location>(response);

            Console.WriteLine(location);

           // StringAssert.Contains(city, location.places[0].placeName);
            Assert.That(location.places.Count, Is.GreaterThan(0));
            //Assert.AreEqual(city, location.places[0].placeName);
        }
    }
}