using SimpleFactory.Pizza;

namespace SimpleFactory.PizzaFactory
{
    class PizzaStore
    {
        private readonly SimplePizzaFactory _pizzaFactory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _pizzaFactory = factory;
        }

        public PizzaBase OrderPizza(string type)
        {
            PizzaBase newPizza = _pizzaFactory.CreatePizza(type);

            if(newPizza != null)
            {
                newPizza.Prepare();
                newPizza.Bake();
                newPizza.Cut();
                newPizza.Box();

                System.Console.WriteLine($"Your {newPizza} is ready!");
                System.Console.WriteLine();
            }

            return newPizza;
        }
    }
}
