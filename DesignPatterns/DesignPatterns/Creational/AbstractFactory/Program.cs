using AbstractFactory.enums;
using AbstractFactory.Factories.Stores;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreFactory nyStore = new NYStoreFactory();
            StoreFactory chicagoStore = new ChicagoStoreFactory();
            StoreFactory californiaStore = new CaliforniaStoreFactory();

            nyStore.OrderPizza(PizzaType.Cheese);
            nyStore.OrderPizza(PizzaType.Veggie);

            chicagoStore.OrderPizza(PizzaType.Clam);
            chicagoStore.OrderPizza(PizzaType.Pepperoni);

            californiaStore.OrderPizza(PizzaType.Cheese);
            californiaStore.OrderPizza(PizzaType.Clam);
        }
    }
}
