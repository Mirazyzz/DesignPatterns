using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients
{
    class SlicedPepperoni : IPepperoni
    {
        public override string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}
