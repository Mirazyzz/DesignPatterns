using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients
{
    class MozzarelaCheese : ICheese
    {
        public override string ToString()
        {
            return "Mozzarela Cheese";
        }
    }
}
