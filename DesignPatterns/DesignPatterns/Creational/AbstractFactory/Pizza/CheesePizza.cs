using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Pizza
{
    class CheesePizza : PizzaBase
    {
        public CheesePizza(IIngredientFactory factory, string name)
            : base(factory, name)
        {
        }

        protected internal override void Prepare()
        {
            Console.WriteLine($"Preparing pizza: {PizzaName}");

            Dough = _ingredientFactory.GetDough();
            Sauce = _ingredientFactory.GetSauce();
            Cheese = _ingredientFactory.GetCheese();

            Bake();
            Cut();
            Box();
        }

        public override string ToString()
        {
            return $"{PizzaName} with {Dough}, {Sauce} and {Cheese}";
        }
    }
}
