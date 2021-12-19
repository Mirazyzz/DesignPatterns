using Decorator.Beverage;

namespace Decorator.Condiment
{
    class Mocha : CondimentDecorator
    {
        public override decimal Price
        {
            get => base.Price + Beverage.Price;
            protected set => base.Price = value;
        }

        public Mocha(BeverageBase beverage)
        {
            Description = "Mocha";
            Price = 0.20m;
            Beverage = beverage;
        }

        public override decimal CalculatePrice() 
            => Beverage == null ? Price : Beverage.Price + Price;
    }
}
