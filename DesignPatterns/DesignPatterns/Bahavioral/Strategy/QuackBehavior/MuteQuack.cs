using System;

namespace Strategy.QuackBehavior
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack...");
        }
    }
}
