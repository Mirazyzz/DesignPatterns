using System.Collections.Generic;

namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    class ChicagoStyleCheesePizza : ChicagoStylePizzaBase
    {
        public ChicagoStyleCheesePizza()
            : base()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";

            Toopings = new List<string>()
            {
                "Shredded Mozzarella Cheese"
            };
        }
    }
}
