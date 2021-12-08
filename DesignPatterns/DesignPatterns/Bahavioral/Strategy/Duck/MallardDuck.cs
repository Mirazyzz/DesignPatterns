using System;

using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using Strategy.SwimBehavior;

namespace Strategy.Duck
{
    class MallardDuck : BaseDuck
    {
        public MallardDuck(string name, double flySpeed, double swimSpeed)
            : base(name: name, flySpeed: flySpeed, swimSpeed: swimSpeed)
        {
        }

        public MallardDuck(string name, double flySpeed, double swimSpeed, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimBehavior swimBehavior)
            : base(name: name, flySpeed: flySpeed, swimSpeed: swimSpeed, flyBehavior: flyBehavior, quackBehavior: quackBehavior, swimBehavior: swimBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"I'm a mallard duck {Name}, I can fly with speed: {FlySpeed} and swim with speed: {SwimSpeed}");
        }
    }
}
