using Decorator.Beverage;

namespace Decorator.Condiment
{
    class Milk : CondimentDecorator
    {
        public override decimal Price 
        {
            get => base.Price + Beverage.Price;
            protected set => base.Price = value; 
        }

        public Milk(BeverageBase beverage)
        {
            Description = "Steamed Milk";
            Price = 0.10m;
            Beverage = beverage;
        }

        public override decimal CalculatePrice() 
            => Beverage == null ? Price : Beverage.Price + Price;
    }
}
