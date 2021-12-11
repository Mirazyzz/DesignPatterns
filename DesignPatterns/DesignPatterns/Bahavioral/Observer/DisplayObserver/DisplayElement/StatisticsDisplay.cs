using System;
using Observer.Models;

namespace Observer.DisplayObserver.DisplayElement
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private MeasurementsData CurrentData;

        public void Display()
        {
            string displayValue = $"| Min Temperature: {CurrentData.MinTemperature}, Max Temperature: {CurrentData.MaxTemperature}, Avg Temperature: {CurrentData.AvgTemperature} |";
            string displayName = "Statistics Display";

            for(int i = 0; i < (displayValue.Length - displayName.Length)/2; i++)
            {
                Console.Write(" ");
            }
            
            Console.Write(displayName);
            Console.WriteLine();

            for(int i = 0; i < displayValue.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine(displayValue);

            for(int i = 0; i < displayValue.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void Update(MeasurementsData data)
        {
            CurrentData = data;

            Display();
        }
    }
}
