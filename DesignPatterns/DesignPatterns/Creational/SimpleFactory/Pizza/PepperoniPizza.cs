using System.Collections.Generic;

namespace SimpleFactory.Pizza
{
    class PepperoniPizza : PizzaBase
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Dough = "Curst";
            Sauce = "Marinara Sauce";

            Toopings = new List<string>()
            {
                "Sliced Pepperoni",
                "Sliced Onion",
                "Grated parmesan cheese"
            };
        }
    }
}
