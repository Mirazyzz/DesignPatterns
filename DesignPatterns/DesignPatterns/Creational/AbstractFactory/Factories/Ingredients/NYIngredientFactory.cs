using AbstractFactory.Ingredients.NYIngredients;
using AbstractFactory.Ingredients.NYIngredients.Toopings;
using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.Ingredients;

using System.Collections.Generic;

namespace AbstractFactory.Factories.Ingredients
{
    class NYIngredientFactory : IIngredientFactory
    {
        public ICheese GetCheese() => new ReggianoCheese();

        public IClam GetClam() => new FreshClam();

        public IDough GetDough() => new ThinCrustDough();

        public IPepperoni GetPepperoni() => new SlicedPepperoni();

        public ISauce GetSauce() => new MarinaraSauce();

        public List<ITooping> GetToopings() => new List<ITooping>()
        {
            new Garlic(),
            new Mushroom(),
            new Onion(),
            new RedPepper()
        };
    }
}
