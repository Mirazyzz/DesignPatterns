using System;

using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using Strategy.SwimBehavior;

namespace Strategy.Duck
{
    class MallardDuck : BaseDuck
    {
        public MallardDuck(string name)
            : base(name: name)
        {
        }

        public MallardDuck(string name, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimBehavior swimBehavior)
            : base(name: name, flyBehavior: flyBehavior, quackBehavior: quackBehavior, swimBehavior: swimBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"I'm {Name} mallard duck.");
        }
    }
}
