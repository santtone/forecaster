using Newtonsoft.Json;

namespace OpenWeatherMapClient.Model
{
    public class WindData
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public double Direction { get; set; }
    }
}