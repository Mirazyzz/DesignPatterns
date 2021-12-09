using System;

namespace Strategy.SwimBehavior
{
    class SwimUnderWater : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine($"Swimming under water with speed");
        }
    }
}
