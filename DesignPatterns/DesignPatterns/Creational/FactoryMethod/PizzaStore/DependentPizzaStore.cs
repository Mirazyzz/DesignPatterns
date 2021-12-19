using FactoryMethod.Pizza;
using FactoryMethod.Pizza.ChicagoStylePizza;
using FactoryMethod.Pizza.NYStylePizza;

namespace FactoryMethod.PizzaStore
{
    class DependentPizzaStore
    {
        public PizzaBase CreatePizza(string style, string type)
        {
            PizzaBase newPizza = null;

            // avoid case sensitive mismatch
            style = style.ToLower();
            type = type.ToLower();

            if(style.Equals("ny") || style.StartsWith("ny"))
            {
                if (type.Equals("cheese"))
                {
                    newPizza = new NYStyleCheesePizza();
                }
                else if (type.Equals("clam"))
                {
                    newPizza = new NYStyleClamPizza();
                }
                else if (type.Equals("veggie"))
                {
                    newPizza = new NYStyleVeggiePizza();
                }
                else if (type.Equals("pepperonni"))
                {
                    newPizza = new NYStylePepperoniPizza();
                }
            }
            else if(style.Equals("chicago") || style.StartsWith("Chicago"))
            {
                if (type.Equals("cheese"))
                {
                    newPizza = new ChicagoStyleCheesePizza();
                }
                else if (type.Equals("clam"))
                {
                    newPizza = new ChicagoStyleClamPizza();
                }
                else if (type.Equals("veggie"))
                {
                    newPizza = new ChicagoStyleVeggiePizza();
                }
                else if (type.Equals("pepperonni"))
                {
                    newPizza = new ChicagoStylePepperoniPizza();
                }
            }

            return newPizza;
        }
    }
}
