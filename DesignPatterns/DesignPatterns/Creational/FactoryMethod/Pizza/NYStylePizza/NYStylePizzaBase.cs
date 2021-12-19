namespace FactoryMethod.Pizza.NYStylePizza
{
    abstract class NYStylePizzaBase : PizzaBase
    {
        public NYStylePizzaBase()
        {
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
        }
    }
}
