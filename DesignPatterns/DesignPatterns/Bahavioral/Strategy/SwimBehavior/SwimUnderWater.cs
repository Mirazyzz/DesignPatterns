using System;

namespace Strategy.SwimBehavior
{
    class SwimUnderWater : ISwimBehavior
    {
        public void Swim(double swimSpeed)
        {
            Console.WriteLine($"Swimming under water with speed {swimSpeed}");
        }
    }
}
