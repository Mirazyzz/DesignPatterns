using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Pizza
{
    class ClamPizza : PizzaBase
    {
        public ClamPizza(IIngredientFactory factory, string name)
            : base(factory, name)
        {
        }

        protected internal override void Prepare()
        {
            Console.WriteLine($"Preparing {PizzaName}...");

            Dough = _ingredientFactory.GetDough();
            Sauce = _ingredientFactory.GetSauce();
            Cheese = _ingredientFactory.GetCheese();
            Clam = _ingredientFactory.GetClam();

            Bake();
            Cut();
            Box();
        }

        public override string ToString()
        {
            return $"{PizzaName} with {Dough}, {Sauce}, {Cheese} and {Clam}";
        }
    }
}
