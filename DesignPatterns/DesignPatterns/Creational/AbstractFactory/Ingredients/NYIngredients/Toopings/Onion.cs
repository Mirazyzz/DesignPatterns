using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients.Toopings
{
    class Onion : ITooping
    {
        public override string ToString()
        {
            return "Onion";
        }
    }
}
