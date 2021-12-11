using Observer.Models;
using System;

namespace Observer.DisplayObserver.DisplayElement
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private MeasurementsData CurrentData;

        public CurrentConditionsDisplay()
        {
            CurrentData = new MeasurementsData();
        }

        public void Display()
        {
            // Save current console color to reset later
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            string displayValue = $"| Temperature: {CurrentData.Temperature} | Humidity: {CurrentData.Humidity} | Pressure: {CurrentData.Pressure} |";
            string displayName = "Current temperature Display";

            for (int i = 0; i < (displayValue.Length - displayName.Length) / 2; i++)
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

            // Reset console color to the one before this display
            Console.ForegroundColor = prevColor;
        }

        public void Update(MeasurementsData data)
        {
            CurrentData = data;

            Display();
        }
    }
}
