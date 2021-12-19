﻿using AbstractFactory.Interfaces.Ingredients;

namespace AbstractFactory.Ingredients.NYIngredients
{
    class ThinCrustDough : Dough
    {
        public override string ToString()
        {
            return "Thin Crust Dough";
        }
    }
}
