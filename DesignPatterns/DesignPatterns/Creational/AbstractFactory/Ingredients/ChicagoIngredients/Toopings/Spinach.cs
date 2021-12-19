using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients.Toopings
{
    class Spinach : ITooping
    {
        public override string ToString()
        {
            return "Spinach";
        }
    }
}
