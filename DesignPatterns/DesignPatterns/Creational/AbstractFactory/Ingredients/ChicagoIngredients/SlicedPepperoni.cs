﻿using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.ChicagoIngredients
{
    class SlicedPepperoni : Pepperoni
    {
        public override string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}
