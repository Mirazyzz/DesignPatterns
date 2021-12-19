using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.CaliforniaIngredients
{
    class FetaCheese : Cheese
    {
        public override string ToString()
        {
            return "Feta Cheese";
        }
    }
}
