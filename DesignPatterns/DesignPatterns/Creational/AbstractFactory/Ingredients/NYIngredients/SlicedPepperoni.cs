using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients
{
    class SlicedPepperoni : IPepperoni
    {
        public override string ToString()
        {
            return "Sliced IPepperoni";
        }
    }
}
