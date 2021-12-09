using System;

using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using Strategy.SwimBehavior;

namespace Strategy.Duck
{
    class RedheadDuck : BaseDuck
    {

        public RedheadDuck(string name)
            : base(name: name)
        {
        }

        public RedheadDuck(string name, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimBehavior swimBehavior)
            : base(name: name, flyBehavior: flyBehavior, quackBehavior: quackBehavior, swimBehavior: swimBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"I'm {Name} readhead duck.");
        }

    }
}
