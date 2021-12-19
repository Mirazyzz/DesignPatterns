using AbstractFactory.Ingredients.ChicagoIngredients;
using AbstractFactory.Ingredients.ChicagoIngredients.Toopings;
using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.Ingredients;

using System.Collections.Generic;

namespace AbstractFactory.Factories.Ingredients
{
    class ChicagoIngredientFactory : IIngredientFactory
    {
        public Cheese GetCheese() => new MozzarelaCheese();

        public Clam GetClam() => new FrozenClam();

        public Dough GetDough() => new ThickCrustDough();

        public Pepperoni GetPepperoni() => new SlicedPepperoni();

        public Sauce GetSauce() => new PlumTomatoSauce();

        public List<Tooping> GetToopings() => new List<Tooping>()
        {
            new BlackOlives(),
            new EggPlant(),
            new Spinach()
        };
    }
}
