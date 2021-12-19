using System.Collections.Generic;

namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    class ChicagoStyleClamPizza : ChicagoStylePizzaBase
    {
        public ChicagoStyleClamPizza()
            : base()
        {
            Name = "Chicago Style Clam Pizza";

            Toopings = new List<string>()
            {
                "Shredded Mozzarella Cheese",
                "Frozen Clams from Chesapeake Bay"
            };
        }
    }
}
