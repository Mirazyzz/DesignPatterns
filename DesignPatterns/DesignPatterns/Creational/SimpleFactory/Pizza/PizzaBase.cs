using System;
using System.Collections.Generic;

namespace SimpleFactory.Pizza
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
            Console.WriteLine($"Preparing {Name}...");
            Console.WriteLine($"Tossing dough...");
            Console.WriteLine($"Adding suace... ");
            Console.Write($"Adding toopings: ");

            for (int i = 0; i < Toopings.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write($" {Toopings[i]}");
                }
                else
                {
                    Console.Write($", {Toopings[i]}");
                }
            }

            Console.WriteLine();
        }

        public virtual void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into 8 pieces");
        }

        public virtual void Box()
        {
            Console.WriteLine("Placing pizza in official PizzaStore box.");
        }

        #endregion

        #region override Object methods

        public override string ToString()
        {
            return $"Pizza: {Name}, Dough: {Dough}, Sauce: {Sauce}, Toopings: {string.Join(",", Toopings)}";
        }

        #endregion
    }
}
