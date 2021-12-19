using AbstractFactory.enums;
using AbstractFactory.Factories.Ingredients;
using AbstractFactory.Interfaces;
using AbstractFactory.Pizzas;

using System;

namespace AbstractFactory.Factories.Stores
{
    class NYStoreFactory : StoreFactory
    {
        protected override PizzaBase CreatePizza(PizzaType pizzaType)
        {
            IIngredientFactory ingredientFactory = new NYIngredientFactory();

            if(pizzaType == PizzaType.Cheese)
            {
                return new CheesePizza(ingredientFactory, "NY Style Cheese Pizza");
            }
            else if(pizzaType == PizzaType.Clam)
            {
                return new ClamPizza(ingredientFactory, "NY Style Clam Pizza");
            }
            else if(pizzaType == PizzaType.Pepperoni)
            {
                return new PepperoniPizza(ingredientFactory, "NY Style Pepperoni Pizza");
            }
            else if(pizzaType == PizzaType.Veggie)
            {
                return new VeggiePizza(ingredientFactory, "NY Style Veggie Pizza");
            }
            else
            {
                throw new Exception($"Invalid pizza type was selected {pizzaType}. Please, try again.");
            }
        }
    }
}
