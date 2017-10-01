using System;
using System.Linq;
using OpenWeatherMapClient;

namespace Forecaster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("FORECASTER");

            Console.Write("Type location: ");
            var location = Console.ReadLine();

            var weatherClient = new WeatherClient("ea574594b9d36ab688642d5fbeab847e");
            weatherClient.GetForecastByLocation(location)
                .ContinueWith(task =>
                {
                    var forecast = task.Result;
                    Console.WriteLine("");
                    Console.WriteLine(
                        $"{forecast.Measurement.Temperature}{(char) 176}C / {forecast.Desctiptions.First().Type}");
                });
            Console.Write("Finding Weather data...");

            Console.ReadLine();
        }
    }
}