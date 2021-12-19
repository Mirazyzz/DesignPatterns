using AbstractFactory.enums;
using AbstractFactory.Factories.Ingredients;
using AbstractFactory.Interfaces;
using AbstractFactory.Pizzas;

using System;

namespace AbstractFactory.Factories.Stores
{
    class CaliforniaStoreFactory : StoreFactory
    {
        protected override PizzaBase CreatePizza(PizzaType pizzaType)
        {
            IIngredientFactory ingredientFactory = new CaliforniaIngredientFactory();

            if (pizzaType == PizzaType.Cheese)
            {
                return new CheesePizza(ingredientFactory, "California Style Cheese Pizza");
            }
            else if (pizzaType == PizzaType.Clam)
            {
                return new ClamPizza(ingredientFactory, "California Style Clam Pizza");
            }
            else if (pizzaType == PizzaType.Pepperoni)
            {
                return new PepperoniPizza(ingredientFactory, "California Style Pepperoni Pizza");
            }
            else if (pizzaType == PizzaType.Veggie)
            {
                return new VeggiePizza(ingredientFactory, "California Style Veggie Pizza");
            }
            else
            {
                throw new Exception($"Invalid pizza type was entered: {pizzaType}. Please, try again.");
            }
        }
    }
}
