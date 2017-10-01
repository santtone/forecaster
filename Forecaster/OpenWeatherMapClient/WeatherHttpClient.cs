using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherMapClient
{
    public class WeatherHttpClient
    {
        private const string ApiUrlBase = "https://api.openweathermap.org/data/2.5/weather?";
        private const string UnitParameter = "units=metric";

        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public WeatherHttpClient(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> GetAsync(string parameters)
        {
            var response = await _httpClient.GetAsync(BuildUrlWithParams(parameters));

            if (response.IsSuccessStatusCode)
                return response;

            var data = await response.Content.ReadAsStringAsync();
            throw new Exception($"Failed to get Weather data from OpenWeatherMap API. Response Content = {data}");
        }

        private string BuildUrlWithParams(string parameters)
        {
            return $"{ApiUrlBase}&APPID={_apiKey}&{UnitParameter}&{parameters}";
        }
    }
}