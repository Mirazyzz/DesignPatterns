using System.Collections.Generic;

namespace SimpleFactory.Pizza
{
    class ClamPizza : PizzaBase
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Dough = "Thin Crust";
            Sauce = "White Garlic Sauce";

            Toopings = new List<string>()
            {
                "Clams",
                "Grated parmesan cheese"
            };
        }
    }
}
