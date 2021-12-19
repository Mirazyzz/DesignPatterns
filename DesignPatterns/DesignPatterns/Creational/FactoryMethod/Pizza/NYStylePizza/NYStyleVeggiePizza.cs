using System.Collections.Generic;

namespace FactoryMethod.Pizza.NYStylePizza
{
    class NYStyleVeggiePizza : NYStylePizzaBase
    {
        public NYStyleVeggiePizza()
            : base()
        {
            Name = "NY Style Veggie Pizza";

            Toopings = new List<string>()
            {
                "Grated Reggiano Cheese",
                "Garlic",
                "Onion",
                "Mushrooms",
                "Red Pepper"
            };
        }
    }
}
