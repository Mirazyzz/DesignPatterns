using AbstractFactory.Ingredients.CaliforniaIngredients;
using AbstractFactory.Ingredients.CaliforniaIngredients.Toopings;
using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.Ingredients;

using System.Collections.Generic;

namespace AbstractFactory.Factories.Ingredients
{
    class CaliforniaIngredientFactory : IIngredientFactory
    {
        public Cheese GetCheese() => new FetaCheese();

        public Clam GetClam() => new ManilaClam();

        public Dough GetDough() => new CrustDough();

        public Pepperoni GetPepperoni() => new RedBellPepperoni();

        public Sauce GetSauce() => new GarlicSauce();

        public List<Tooping> GetToopings() => new List<Tooping>()
        {
            new FreshBasil(),
            new Garlic(),
            new OliveOil(),
            new RedOnion()
        };
    }
}
