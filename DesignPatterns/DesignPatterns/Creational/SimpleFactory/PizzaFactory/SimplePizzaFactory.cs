using SimpleFactory.Pizza;

namespace SimpleFactory.PizzaFactory
{
    class SimplePizzaFactory
    {
        public PizzaBase CreatePizza(string pizzaType)
        {
            // Avoid case sensitive mismatch
            pizzaType = pizzaType.ToLower();

            if (pizzaType.Equals("cheese"))
            {
                return new CheesePizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                return new PepperoniPizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                return new ClamPizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                return new VeggiePizza();
            }
            else
            {
                System.Console.WriteLine($"Invalid pizza type: '{pizzaType}'. Please, try again.");
                return null;
            }
        }
    }
}
