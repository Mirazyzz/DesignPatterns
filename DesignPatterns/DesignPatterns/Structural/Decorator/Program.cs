using Decorator.Beverage;
using Decorator.Condiment;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase darkRoast = new DarkRoast();
            
            // Adding condiments
            CondimentDecorator milk = new Milk(darkRoast);
            CondimentDecorator milk1 = new Milk(milk);
            CondimentDecorator mocha = new Mocha(milk1);
            CondimentDecorator mocha2 = new Mocha(mocha);
            CondimentDecorator soy = new Soy(mocha2);

            System.Console.WriteLine($"{soy.GetFullDescription()} - {soy.CalculatePrice()}");

        }
    }
}
