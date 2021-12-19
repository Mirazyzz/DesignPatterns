using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients
{
    class ReggianoCheese : ICheese
    {
        public override string ToString()
        {
            return "Reggiano Cheese";
        }
    }
}
