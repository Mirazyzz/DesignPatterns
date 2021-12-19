using System;

namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    abstract class ChicagoStylePizzaBase : PizzaBase
    {
        public ChicagoStylePizzaBase()
        {
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
        }
    }
}
