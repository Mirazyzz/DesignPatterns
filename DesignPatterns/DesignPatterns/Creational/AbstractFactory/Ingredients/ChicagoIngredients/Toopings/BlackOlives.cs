using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients.Toopings
{
    class BlackOlives : ITooping
    {
        public override string ToString()
        {
            return "Black Olive";
        }
    }
}
