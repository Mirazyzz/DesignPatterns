using FactoryMethod.Pizza;
using FactoryMethod.Pizza.NYStylePizza;

namespace FactoryMethod.PizzaStore
{
    class NYPizzaStore : PizzaStoreBase
    {
        protected override PizzaBase CreatePizza(string type)
        {
            // Avoid case sensitive mismatch
            type = type.ToLower();

            return type switch
            {
                "cheese" => new NYStyleCheesePizza(),
                "clam" => new NYStyleClamPizza(),
                "veggie" => new NYStyleVeggiePizza(),
                "pepperoni" => new NYStylePepperoniPizza(),
                _ => null,
            };
        }
    }
}
