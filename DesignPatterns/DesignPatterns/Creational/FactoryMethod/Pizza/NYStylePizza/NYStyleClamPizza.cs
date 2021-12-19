using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Pizza.NYStylePizza
{
    class NYStyleClamPizza : NYStylePizzaBase
    {
        public NYStyleClamPizza()
            : base()
        {
            Name = "NY Style Clam Pizza";

            Toopings = new List<string>()
            {
                "Grated Reggiano Cheese",
                "Fresh Clams from Long Island Sound"
            };
        }
    }
}
