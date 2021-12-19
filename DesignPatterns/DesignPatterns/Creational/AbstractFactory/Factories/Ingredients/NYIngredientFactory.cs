using AbstractFactory.Ingredients.NYIngredients;
using AbstractFactory.Ingredients.NYIngredients.Toopings;
using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.Ingredients;

using System.Collections.Generic;

namespace AbstractFactory.Factories.Ingredients
{
    class NYIngredientFactory : IIngredientFactory
    {
        public Cheese GetCheese() => new ReggianoCheese();

        public Clam GetClam() => new FreshClam();

        public Dough GetDough() => new ThinCrustDough();

        public Pepperoni GetPepperoni() => new SlicedPepperoni();

        public Sauce GetSauce() => new MarinaraSauce();

        public List<Tooping> GetToopings() => new List<Tooping>()
        {
            new Garlic(),
            new Mushroom(),
            new Onion(),
            new RedPepper()
        };
    }
}
