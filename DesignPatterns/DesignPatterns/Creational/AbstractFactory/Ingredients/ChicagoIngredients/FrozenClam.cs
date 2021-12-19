using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients
{
    class FrozenClam : IClam
    {
        public override string ToString()
        {
            return "Frozen IClam";
        }
    }
}
