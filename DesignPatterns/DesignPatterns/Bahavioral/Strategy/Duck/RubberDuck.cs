using System;

using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using Strategy.SwimBehavior;

namespace Strategy.Duck
{
    class RubberDuck : BaseDuck
    {

        public RubberDuck(string name, double flySpeed, double swimSpeed)
            : base(name: name, flySpeed: flySpeed, swimSpeed: swimSpeed)
        {
        }

        public RubberDuck(string name, double flySpeed, double swimSpeed, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimBehavior swimBehavior)
            : base(name: name, flySpeed: flySpeed, swimSpeed: swimSpeed, flyBehavior: flyBehavior, quackBehavior: quackBehavior, swimBehavior: swimBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"I'm {Name} readhead duck, I can swim with speed: {SwimSpeed} and fly with speed: {FlySpeed}");
        }

    }
}
