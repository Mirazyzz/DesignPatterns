using System;

namespace Strategy.FlyBehavior
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly...");
        }
    }
}
