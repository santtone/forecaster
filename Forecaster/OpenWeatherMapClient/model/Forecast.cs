using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenWeatherMapClient.Model
{
    public class Forecast
    {
        [JsonProperty("name")]
        public string LocationName { get; set; }

        [JsonProperty("coord")]
        public Geolocation Geolocation { get; set; }

        [JsonProperty("main")]
        public MeasurementData Measurement { get; set; }

        [JsonProperty("wind")]
        public WindData Wind { get; set; }

        [JsonProperty("weather")]
        public List<WeatherDesctiption> Desctiptions { get; set; }
    }
}