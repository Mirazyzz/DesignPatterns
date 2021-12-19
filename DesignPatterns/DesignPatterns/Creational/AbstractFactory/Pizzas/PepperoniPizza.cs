using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Pizzas
{
    class PepperoniPizza : PizzaBase
    {
        public PepperoniPizza(IIngredientFactory factory, string name)
            : base(factory, name)
        {
        }

        protected internal override void Prepare()
        {
            Console.WriteLine($"Preparing {PizzaName}...");

            Dough = _ingredientFactory.GetDough();
            Sauce = _ingredientFactory.GetSauce();
            Cheese = _ingredientFactory.GetCheese();
            Pepperoni = _ingredientFactory.GetPepperoni();

            Bake();
            Cut();
            Box();
        }

        public override string ToString()
        {
            return $"{PizzaName} with {Dough}, {Sauce}, {Cheese} and {Pepperoni}";
        }
    }
}
