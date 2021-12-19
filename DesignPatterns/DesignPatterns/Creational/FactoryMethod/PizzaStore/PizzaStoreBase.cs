using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
    abstract class PizzaStore
    {
        public PizzaBase OrderPizza(string type)
        {
            PizzaBase pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract PizzaBase CreatePizza(string type);
    }
}
