using System;

namespace Strategy.SwimBehavior
{
    class SwimWithBoat : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine($"Swimming on boat with speed");
        }
    }
}
