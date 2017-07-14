using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class WeatherInfo
{
    public double Temperature { get; set; }
    public string WeatherType { get; set; }
}

class Weather
{
    static void Main(string[] args)
    {
        var result = new Dictionary<string, WeatherInfo>();
        string input = null;
        Regex regex = new Regex(@"([A-Z]{2})([\d.]+)([A-Za-z]+)\|");

        while ((input = Console.ReadLine()) != "end")
        {
            Match matcher = regex.Match(input);

            while (matcher.Success)
            {
                string city = matcher.Groups[1].Value;
                double temperature = double.Parse(matcher.Groups[2].Value);
                string weatherType = matcher.Groups[3].Value;

                WeatherInfo weatherInfo = new WeatherInfo();
                weatherInfo.Temperature = temperature;
                weatherInfo.WeatherType = weatherType;

                result[city] = weatherInfo;

                matcher = matcher.NextMatch();
            }
        }
        result = result.OrderBy(a => a.Value.Temperature).ToDictionary(a => a.Key, a => a.Value);

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} => {item.Value.Temperature:f2} => {item.Value.WeatherType}");
        }
    }
}

