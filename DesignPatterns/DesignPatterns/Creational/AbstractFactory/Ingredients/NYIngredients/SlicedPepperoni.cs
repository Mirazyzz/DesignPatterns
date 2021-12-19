using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients
{
    class SlicedPepperoni : Pepperoni
    {
        public override string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}
