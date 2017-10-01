using Newtonsoft.Json;

namespace OpenWeatherMapClient.model
{
    public class WeatherDesctiption
    {
        [JsonProperty("description")]
        public string Type { get; set; }
    }
}