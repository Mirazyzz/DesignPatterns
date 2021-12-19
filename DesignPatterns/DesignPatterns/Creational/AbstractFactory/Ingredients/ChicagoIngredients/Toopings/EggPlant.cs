using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients.Toopings
{
    class EggPlant : ITooping
    {
        public override string ToString()
        {
            return "Egg Plant";
        }
    }
}
