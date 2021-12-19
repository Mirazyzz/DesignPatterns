using System.Collections.Generic;

namespace SimpleFactory.Pizza
{
    class CheesePizza : PizzaBase
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara Pizza Sauce";

            Toopings = new List<string>()
            {
                "Fresh Mozzarella",
                "Parmesan"
            };
        }
    }
}
