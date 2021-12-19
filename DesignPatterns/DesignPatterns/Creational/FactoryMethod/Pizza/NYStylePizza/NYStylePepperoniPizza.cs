using System.Collections.Generic;

namespace FactoryMethod.Pizza.NYStylePizza
{
    class NYStylePepperoniPizza : NYStylePizzaBase
    {
        public NYStylePepperoniPizza()
        {
            Name = "NY Style Pepperoni Pizza";

            Toopings = new List<string>()
            {
                "Grated Reggiano Cheese",
                "Sliced Pepperoni",
                "Garlic",
                "Onion",
                "Mushrooms",
                "Red Pepper"
            };
        }
    }
}
