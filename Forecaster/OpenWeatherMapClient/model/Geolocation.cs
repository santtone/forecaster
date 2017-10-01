using Newtonsoft.Json;

namespace OpenWeatherMapClient.model
{
    public class Geolocation
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}