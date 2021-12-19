using System.Collections.Generic;
using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Interfaces
{
    interface IIngredientFactory
    {
        public IDough GetDough();
        public ISauce GetSauce();
        public ICheese GetCheese();
        public IPepperoni GetPepperoni();
        public IClam GetClam();
        public List<ITooping> GetToopings();
    }
}
