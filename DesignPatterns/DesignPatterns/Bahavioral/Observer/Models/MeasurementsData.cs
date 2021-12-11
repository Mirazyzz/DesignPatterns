namespace Observer.Models
{
    class MeasurementsData
    {
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }
        public float MinTemperature { get; private set; }
        public float MaxTemperature { get; private set; }
        public float AvgTemperature { get; private set; }
        public string Forecast { get; private set; }

        public MeasurementsData()
        {
            Temperature = 0;
            Humidity = 0;
            Pressure = 0;
            MinTemperature = 0;
            MaxTemperature = 0;
            AvgTemperature = 0;
            Forecast = "";
        }

        public MeasurementsData(float temperature, float humidity, float pressure,
                                float minTemperature, float maxTemperature, float avgTemperature,
                                string forecast)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MinTemperature = minTemperature;
            MaxTemperature = maxTemperature;
            AvgTemperature = avgTemperature;
            Forecast = forecast;
        }

        public void UpdateTemperature(float temperature)
        {
            // provide some logic

            Temperature = temperature;
        }

        public void UpdateHumidity(float humidity)
        {
            // provide some logic

            Humidity = humidity;
        }

        public void UpdatePressure(float pressure)
        {
            // provide some logic

            Pressure = pressure;
        }

        public void UpdateMinTemperature(float minTemperature)
        {
            // provide some logic

            MinTemperature = minTemperature;
        }

        public void UpdateMaxTemperature(float maxTemperature)
        {
            // provide some logic

            MaxTemperature = maxTemperature;
        }

        public void UpdateAvgTemperature(float avgTemperature)
        {
            // provide some logic

            AvgTemperature = avgTemperature;
        }

        public void UpdateForecast(string forecast)
        {
            // provide some logic

            Forecast = forecast;
        }
    }
}
