using System;
using System.Collections.Generic;

using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Interfaces
{
    abstract class PizzaBase
    {
        private protected readonly IIngredientFactory _ingredientFactory;

        public string PizzaName { get; protected set; }

        public Dough Dough { get; protected set; }
        public Sauce Sauce { get; protected set; }
        public Cheese Cheese { get; protected set; }
        public Pepperoni Pepperoni { get; protected set; }
        public Clam Clam { get; protected set; }
        public List<Tooping> Toopings { get; protected set; }

        public PizzaBase(IIngredientFactory factory, string name)
        {
            _ingredientFactory = factory;
            PizzaName = name;
        }

        protected internal abstract void Prepare();

        protected virtual void Bake()
        {
            Console.WriteLine("Baking the pizza for 25 mins under 360...");
        }

        protected virtual void Cut()
        {
            Console.WriteLine("Cutting down the pizza into 8 pieces...");
        }

        protected virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box...");

            Console.WriteLine($"Your {this} is ready!");
            Console.WriteLine();
        }
    }
}
