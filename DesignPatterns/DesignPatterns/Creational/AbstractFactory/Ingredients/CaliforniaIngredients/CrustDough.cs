using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.CaliforniaIngredients
{
    class CrustDough : Dough
    {
        public override string ToString()
        {
            return "Crust Dough";
        }
    }
}
