using System;

using Observer.DisplayObserver;
using Observer.DisplayObserver.DisplayElement;
using Observer.Publisher;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData publisher = new WeatherData();

            IObserver forecastDisplay = new ForecastDisplay();
            IObserver statisticsDisplay = new StatisticsDisplay();
            IObserver currentConditionsDisplay = new CurrentConditionsDisplay();

            publisher.RegisterObserver(forecastDisplay);
            publisher.RegisterObserver(statisticsDisplay);
            publisher.RegisterObserver(currentConditionsDisplay);

            publisher.StartUpdatingWeatherData();

            Console.ReadLine();
        }
    }
}
