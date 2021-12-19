using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Pizza.NYStylePizza
{
    class NYStylePizzaBase : PizzaBase
    {
        public NYStylePizzaBase()
        {
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
        }
    }
}
