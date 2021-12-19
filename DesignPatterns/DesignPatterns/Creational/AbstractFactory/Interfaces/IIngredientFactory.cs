using System.Collections.Generic;
using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Interfaces
{
    interface IIngredientFactory
    {
        public Dough GetDough();
        public Sauce GetSauce();
        public Cheese GetCheese();
        public Pepperoni GetPepperoni();
        public Clam GetClam();
        public List<Tooping> GetToopings();
    }
}
