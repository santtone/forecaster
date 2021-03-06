﻿using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenWeatherMapClient.Model;
using System;

namespace OpenWeatherMapClient
{
    public class WeatherClient
    {
        private readonly WeatherHttpClient _weatherHttpClient;

        public WeatherClient(string apiKey)
        {
            _weatherHttpClient = new WeatherHttpClient(apiKey);
        }

        public async Task<Forecast> GetForecastByLocation(string locationName)
        {
            string parameters = $"q={locationName}";
            var response = await _weatherHttpClient.GetAsync(parameters);
            var data = await response.Content.ReadAsStringAsync();
            try
            {
                return JsonConvert.DeserializeObject<Forecast>(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to deserialize weather data", ex);
            }
        }

    }
}
