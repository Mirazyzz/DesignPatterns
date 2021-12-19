using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients
{
    class FreshClam : IClam
    {
        public override string ToString()
        {
            return "Fresh IClam";
        }
    }
}
