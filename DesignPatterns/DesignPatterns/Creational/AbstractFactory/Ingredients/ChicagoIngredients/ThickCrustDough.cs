using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients
{
    class ThickCrustDough : Dough
    {
        public override string ToString()
        {
            return "Thick Crust Dough";
        }
    }
}
