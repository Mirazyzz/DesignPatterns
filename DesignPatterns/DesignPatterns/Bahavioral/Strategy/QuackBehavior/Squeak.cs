using System;

namespace Strategy.QuackBehavior
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeaking the way normal ducks do :)");
        }
    }
}
