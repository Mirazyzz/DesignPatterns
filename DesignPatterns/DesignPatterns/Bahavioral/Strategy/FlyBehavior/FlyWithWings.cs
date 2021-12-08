using System;

namespace Strategy.FlyBehavior
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly(double flySpeed)
        {
            Console.WriteLine($"I'm flying high with speed {flySpeed}!");
        }
    }
}
