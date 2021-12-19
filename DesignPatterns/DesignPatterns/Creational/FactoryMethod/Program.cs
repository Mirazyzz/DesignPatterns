using FactoryMethod.PizzaStore;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStoreBase nyStore = new NYPizzaStore();
            PizzaStoreBase chicagoStore = new ChicagoPizzaStore();

            // Making NY style pizzas
            var nyCheesePizza = nyStore.OrderPizza("cheese");
            var nyVeggiePizza = nyStore.OrderPizza("veggie");

            // Making Chicago style pizzas
            var chicagoPepperoniPizza = chicagoStore.OrderPizza("pepperoni");
            var chicagoClamPizza = chicagoStore.OrderPizza("clam");
        }
    }
}
