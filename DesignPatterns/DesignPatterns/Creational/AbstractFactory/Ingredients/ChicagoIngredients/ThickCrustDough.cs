using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients
{
    class ThickCrustDough : IDough
    {
        public override string ToString()
        {
            return "Thick Crust Dough";
        }
    }
}
