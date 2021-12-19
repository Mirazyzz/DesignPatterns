using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
    abstract class PizzaStoreBase
    {
        public PizzaBase OrderPizza(string type)
        {
            PizzaBase pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            System.Console.WriteLine($"Your pizza {pizza} is read!");
            System.Console.WriteLine();

            return pizza;
        }

        protected abstract PizzaBase CreatePizza(string type);
    }
}
