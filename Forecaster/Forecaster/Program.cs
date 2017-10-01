using System;
using OpenWeatherMapClient;

namespace Forecaster
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var weatherClient = new WeatherClient("ea574594b9d36ab688642d5fbeab847e");
            var forecast = weatherClient.GetForecastByLocation("Kouvola").Result;
            Console.WriteLine(forecast.Measurement.Temperature);
            Console.ReadLine();
        }
    }
}
