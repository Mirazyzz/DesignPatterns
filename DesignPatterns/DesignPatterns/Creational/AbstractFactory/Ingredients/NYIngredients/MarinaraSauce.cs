using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients
{
    class MarinaraSauce : ISauce
    {
        public override string ToString()
        {
            return "Marinara ISauce";
        }
    }
}
