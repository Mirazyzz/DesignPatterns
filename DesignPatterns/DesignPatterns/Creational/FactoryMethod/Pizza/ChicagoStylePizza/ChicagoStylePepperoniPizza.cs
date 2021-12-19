using System.Collections.Generic;

namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    class ChicagoStylePepperoniPizza : ChicagoStylePizzaBase
    {
        public ChicagoStylePepperoniPizza()
            : base() 
        {
            Name = "Chicago Style Pepperoni Pizza"; 

            Toopings = new List<string>() 
            { 
                "Shredded Mozzarella Cheese", 
                "Black Olives", 
                "Spinach",
                "Eggplant", 
                "Sliced Pepperoni" 
            }; 
        }
    }
}
