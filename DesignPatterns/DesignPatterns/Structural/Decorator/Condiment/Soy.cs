using Decorator.Beverage;

namespace Decorator.Condiment
{
    class Soy : CondimentDecorator
    {
        public override decimal Price
        {
            get => base.Price + Beverage.Price;
            protected set => base.Price = value;
        }

        public Soy(BeverageBase beverage)
        {
            Description = "Soy";
            Price = 0.15m;
            Beverage = beverage;
        }

        public override decimal CalculatePrice() 
            => Beverage == null ? Price : Beverage.Price + Price;
    }
}
