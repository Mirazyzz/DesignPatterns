using System;
using System.Collections.Generic;

namespace FactoryMethod.Pizza
{
    abstract class PizzaBase
    {
        public virtual string Name { get; protected set; }
        public virtual string Dough { get; protected set; }
        public virtual string Sauce { get; protected set; }
        public virtual List<string> Toopings { get; protected set; }

        public PizzaBase()
        {
            Name = "";
            Dough = "";
            Sauce = "";
            Toopings = new List<string>();
        }

        #region Pizza prepartion methods

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing: {Name}...");
            Console.WriteLine($"Tossing dough...");
            Console.WriteLine($"Adding suace... ");
            Console.WriteLine($"Adding toopings: ");

            foreach(string tooping in Toopings)
            {
                Console.Write($"{tooping} ");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into 8 pieces");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        #endregion
    }
}
