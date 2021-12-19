using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients
{
    class ThinCrustDough : IDough
    {
        public override string ToString()
        {
            return "Thin Crust Dough";
        }
    }
}
