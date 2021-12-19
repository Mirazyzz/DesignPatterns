using AbstractFactory.enums;
using AbstractFactory.Factories.Ingredients;
using AbstractFactory.Interfaces;
using AbstractFactory.Pizzas;

using System;

namespace AbstractFactory.Factories.Stores
{
    class ChicagoStoreFactory : StoreFactory
    {
        protected override PizzaBase CreatePizza(PizzaType pizzaType)
        {
            IIngredientFactory ingredientFactory = new ChicagoIngredientFactory();

            if (pizzaType == PizzaType.Cheese)
            {
                return new CheesePizza(ingredientFactory, "Chicago Style Cheese Pizza");
            }
            else if (pizzaType == PizzaType.Clam)
            {
                return new ClamPizza(ingredientFactory, "Chicago Style Clam Pizza");
            }
            else if (pizzaType == PizzaType.Pepperoni)
            {
                return new PepperoniPizza(ingredientFactory, "Chicago Style Pepperoni Pizza");
            }
            else if (pizzaType == PizzaType.Veggie)
            {
                return new VeggiePizza(ingredientFactory, "Chicago Style Veggie Pizza");
            }
            else
            {
                throw new Exception($"Invalid pizza type was selected ${pizzaType}. Please, try again.");
            }
        }
    }
}
