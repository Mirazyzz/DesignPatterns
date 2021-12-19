using AbstractFactory.Ingredients.ChicagoIngredients;
using AbstractFactory.Ingredients.ChicagoIngredients.Toopings;
using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.Ingredients;

using System.Collections.Generic;

namespace AbstractFactory.Factories.Ingredients
{
    class ChicagoIngredientFactory : IIngredientFactory
    {
        public ICheese GetCheese() => new MozzarelaCheese();

        public IClam GetClam() => new FrozenClam();

        public IDough GetDough() => new ThickCrustDough();

        public IPepperoni GetPepperoni() => new SlicedPepperoni();

        public ISauce GetSauce() => new PlumTomatoSauce();

        public List<ITooping> GetToopings() => new List<ITooping>()
        {
            new BlackOlives(),
            new EggPlant(),
            new Spinach()
        };
    }
}
