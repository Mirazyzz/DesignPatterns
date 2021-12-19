using Decorator.Beverage;

namespace Decorator.Condiment
{
    class Whip : CondimentDecorator
    {
        public override decimal Price
        {
            get => base.Price + Beverage.Price;
            protected set => base.Price = value;
        }

        public Whip(BeverageBase beverage)
        {
            Description = "Whip";
            Price = 0.10m;
            Beverage = beverage;
        }

        public override decimal CalculatePrice() 
            => Beverage == null ? Price : Beverage.Price + Price;
    }
}
