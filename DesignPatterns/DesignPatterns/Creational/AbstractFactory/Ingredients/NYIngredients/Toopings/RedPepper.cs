using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients.Toopings
{
    class RedPepper : ITooping
    {
        public override string ToString()
        {
            return "Red Pepper";
        }
    }
}
