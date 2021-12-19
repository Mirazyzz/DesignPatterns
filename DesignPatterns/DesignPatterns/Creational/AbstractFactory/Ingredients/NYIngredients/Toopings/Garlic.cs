using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients.Toopings
{
    class Garlic : ITooping
    {
        public override string ToString()
        {
            return "Garlic";
        }
    }
}
