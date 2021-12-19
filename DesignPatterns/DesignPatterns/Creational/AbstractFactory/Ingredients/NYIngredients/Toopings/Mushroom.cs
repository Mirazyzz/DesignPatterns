using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients.Toopings
{
    class Mushroom : ITooping
    {
        public override string ToString()
        {
            return "Mushroom";
        }
    }
}
