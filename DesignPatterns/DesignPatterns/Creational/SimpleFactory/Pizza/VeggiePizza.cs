using System.Collections.Generic;

namespace SimpleFactory.Pizza
{
    class VeggiePizza : PizzaBase
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            Dough = "Crust";
            Sauce = "Marinara Sauce";

            Toopings = new List<string>()
            {
                "Shredded mozzarella",
                "Grated parmesan",
                "Diced onion",
                "Sliced mushrooms",
                "Sliced red pepper",
                "Sliced black olives"
            };
        }
    }
}
