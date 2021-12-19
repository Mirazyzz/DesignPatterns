namespace Decorator.Beverage
{
    abstract class BeverageBase
    {
        public virtual BeverageBase Beverage { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual decimal Price { get; protected set; }
    }
}
