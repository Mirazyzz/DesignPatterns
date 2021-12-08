using System;

namespace Strategy.SwimBehavior
{
    class SwimWithBoat : ISwimBehavior
    {
        public void Swim(double swimSpeed)
        {
            Console.WriteLine($"Swimming on boat with speed {swimSpeed}");
        }
    }
}
