using SimpleFactory.PizzaFactory;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PizzaStore(new SimplePizzaFactory());

            store.OrderPizza("cheese");
            store.OrderPizza("veggie");
            store.OrderPizza("some pizza");
        }
    }
}
