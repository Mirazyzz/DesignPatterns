using System;

namespace Strategy.FlyBehavior
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly(double flySpeed)
        {
            Console.WriteLine("I can't fly...");
        }
    }
}
