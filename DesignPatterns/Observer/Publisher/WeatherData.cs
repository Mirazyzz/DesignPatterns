using System;
using System.Collections.Generic;
using System.Timers;

using Observer.DisplayObserver;
using Observer.Models;

namespace Observer.Publisher
{
    class WeatherData : ISubject
    {
        public HashSet<IObserver> Observers { get; private set; }
        private readonly MeasurementsData CurrentData;
        private readonly Timer Timer;

        public WeatherData()
        {
            Observers = new HashSet<IObserver>();
            CurrentData = new MeasurementsData();
            Timer = new Timer();
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in Observers)
            {
                observer.Update(CurrentData);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if(observer == null)
            {
                Console.WriteLine("Observer cannot be null.");

                return;
            }

            if (Observers.Contains(observer))
            {
                Console.WriteLine("The observer has already subscribed to the Publisher");

                return;
            }

            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observer == null)
            {
                Console.WriteLine("Observer cannot be null.");

                return;
            }

            if (!Observers.Contains(observer))
            {
                Console.WriteLine("The observer is not subscribed to the Publisher");

                return;
            }

            Observers.Remove(observer);
        }

        public void StartUpdatingWeatherData()
        {
            Timer.Interval = 3000;
            Timer.Elapsed += GenerateRandomWeatherData;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private void GenerateRandomWeatherData(object source, ElapsedEventArgs e)
        {
            UpdateWeatherData();

            NotifyObservers();
        }

        private void UpdateWeatherData()
        {
            float temperature = GenerateRandomTemperature();
            float humidity = GenerateRandomHumidity();
            float pressure = GenerateRandomPressure();
            float minTemperature = GenerateRandomMinTemperature();
            float maxTemperature = GenerateRandomMaxTemperature();
            float avgTemperature = GenerateRandomAvgTemperature();
            string forecast = GenerateRandomForecast();

            CurrentData.UpdateTemperature(temperature);
            CurrentData.UpdateHumidity(humidity);
            CurrentData.UpdatePressure(pressure);
            CurrentData.UpdateMinTemperature(minTemperature);
            CurrentData.UpdateMaxTemperature(maxTemperature);
            CurrentData.UpdateAvgTemperature(avgTemperature);
            CurrentData.UpdateForecast(forecast);
        }

        private float GenerateRandomTemperature()
        {
            double min = -50;
            double max = 50;

            float randomTemperature = (float)(new Random().NextDouble() * (max - min) + min);

            return randomTemperature;
        }

        private float GenerateRandomHumidity()
        {
            double min = 0;
            double max = 100;

            float randomHumidity = (float)(new Random().NextDouble() * (max - min) + min);

            return randomHumidity;
        }

        private float GenerateRandomPressure()
        {
            double min = -6000;
            double max = 6000;

            float randomPressure = (float)(new Random().NextDouble() * (max - min) + min);

            return randomPressure;
        }

        private float GenerateRandomMinTemperature()
        {
            double min = -6000;
            double max = 6000;

            float randomPressure = (float)(new Random().NextDouble() * (max - min) + min);

            return randomPressure;
        }

        private float GenerateRandomMaxTemperature()
        {
            double min = -6000;
            double max = 6000;

            float randomPressure = (float)(new Random().NextDouble() * (max - min) + min);

            return randomPressure;
        }

        private float GenerateRandomAvgTemperature()
        {
            double min = -6000;
            double max = 6000;

            float randomPressure = (float)(new Random().NextDouble() * (max - min) + min);

            return randomPressure;
        }

        private string GenerateRandomForecast()
        {
            List<string> forecasts = new List<string>()
            {
                "Improving weather on the way",
                "Weather is getting colder",
                "It's going to be raining",
                "Snowfall"
            };

            return forecasts[new Random().Next(0, forecasts.Count)];
        }
    }
}
