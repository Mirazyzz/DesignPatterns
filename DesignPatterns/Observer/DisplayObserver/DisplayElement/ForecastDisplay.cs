using System;
using Observer.Models;

namespace Observer.DisplayObserver.DisplayElement
{
    class ForecastDisplay : IDisplayElement, IObserver
    {
        private MeasurementsData CurrentData;

        public ForecastDisplay()
        {
            CurrentData = new MeasurementsData();
        }

        public void Display()
        {
            // Save current color to reset later
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            string displayValue = $"| Forecast: {CurrentData.Forecast} |";
            string displayName = "Forecast Display";

            for(int i = 0; i < Math.Abs(displayValue.Length - displayName.Length) / 2; i++)
            {
                Console.Write(" ");
            }

            Console.Write(displayName);
            Console.WriteLine();

            for (int i = 0; i < displayValue.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine(displayValue);

            for (int i = 0; i < displayValue.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = prevColor;
        }

        public void Update(MeasurementsData data)
        {
            CurrentData = data;

            Display();
        }
    }
}
