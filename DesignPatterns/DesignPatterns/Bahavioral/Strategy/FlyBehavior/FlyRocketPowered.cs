using System;

namespace Strategy.FlyBehavior
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void Fly(double flySpeed)
        {
            Console.WriteLine($"I'm flying with a rocket speed {flySpeed}!!!");
        }
    }
}
