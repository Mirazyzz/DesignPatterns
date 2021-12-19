using FactoryMethod.Pizza;
using FactoryMethod.Pizza.ChicagoStylePizza;

namespace FactoryMethod.PizzaStore
{
    class ChicagoPizzaStore : PizzaStoreBase
    {
        protected override PizzaBase CreatePizza(string type)
        {
            // Avoid case sensitive mismatch
            type = type.ToLower();

            return type switch
            {
                "cheese" => new ChicagoStyleCheesePizza(),
                "clam" => new ChicagoStyleClamPizza(),
                "veggie" => new ChicagoStyleVeggiePizza(),
                "pepperoni" => new ChicagoStylePepperoniPizza(),
                _ => null,
            };
        }
    }
}
