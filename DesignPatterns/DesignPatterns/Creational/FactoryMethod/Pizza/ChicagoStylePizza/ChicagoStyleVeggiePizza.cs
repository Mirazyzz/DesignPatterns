using System.Collections.Generic;

namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    class ChicagoStyleVeggiePizza : ChicagoStylePizzaBase
    {
        public ChicagoStyleVeggiePizza()
            : base()
        {
            Name = "Chicago Style Deep Dish Veggie Pizza";

            Toopings = new List<string>()
            {
                "Shredded Mozzarella Cheese",
                "Black Olives",
                "Spinach",
                "Eggplant"
            };
        }
    }
}
