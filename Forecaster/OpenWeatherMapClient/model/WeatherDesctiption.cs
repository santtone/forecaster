using Newtonsoft.Json;

namespace OpenWeatherMapClient.Model
{
    public class WeatherDesctiption
    {
        [JsonProperty("description")]
        public string Type { get; set; }
    }
}