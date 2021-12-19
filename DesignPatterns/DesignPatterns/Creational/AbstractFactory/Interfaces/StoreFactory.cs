using AbstractFactory.enums;

namespace AbstractFactory.Interfaces
{
    abstract class StoreFactory
    {
        protected abstract PizzaBase CreatePizza(PizzaType pizzaType);

        internal PizzaBase OrderPizza(PizzaType pizzaType)
        {
            PizzaBase pizza = CreatePizza(pizzaType);

            pizza.Prepare();

            return pizza;
        }
    }
}
