using System.Collections.Generic;

namespace FactoryMethod.Pizza.NYStylePizza
{
    class NYStyleCheesePizza : NYStylePizzaBase
    {
        public NYStyleCheesePizza()
            : base()
        {
            Name = "NY Style Sauce and Cheese Pizza";

            Toopings = new List<string>()
            {
                "Grated Reggiano Cheese"
            };
        }
    }
}
