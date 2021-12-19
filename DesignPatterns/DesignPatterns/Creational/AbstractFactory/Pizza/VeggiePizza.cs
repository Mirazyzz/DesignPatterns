using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Pizza
{
    class VeggiePizza : PizzaBase
    {
        public VeggiePizza(IIngredientFactory factory, string name)
            : base(factory, name)
        {

        }
        protected internal override void Prepare()
        {
            Console.WriteLine($"Preparing {PizzaName}...");

            Dough = _ingredientFactory.GetDough();
            Sauce = _ingredientFactory.GetSauce();
            Cheese = _ingredientFactory.GetCheese();
            Toopings = _ingredientFactory.GetToopings();

            Bake();
            Cut();
            Box();
        }

        public override string ToString()
        {
            return $"{PizzaName} with {Dough}, {Sauce}, {Cheese}, {string.Join(", ", Toopings)}";
        }
    }
}
