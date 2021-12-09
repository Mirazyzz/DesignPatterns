using System;

using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using Strategy.SwimBehavior;

namespace Strategy.Duck
{

    abstract class BaseDuck
    {
        protected virtual string Name { get; set; }

        #region Behaviors

        protected virtual IFlyBehavior FlyBehavior { get; set; }
        protected virtual IQuackBehavior QuackBehavior { get; set; }
        protected virtual ISwimBehavior SwimBehavior { get; set; }

        #endregion

        public BaseDuck(string name)
        {
            Name = name;
        }

        public BaseDuck(string name, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimBehavior swimBehavior)
            : this(name)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
            SwimBehavior = swimBehavior;
        }

        public abstract void Display();

        public virtual void Swim()
        {
            SwimBehavior.Swim();
        }
        public virtual void Quack()
        {
            QuackBehavior.Quack();
        }
        public virtual void Fly()
        {
            FlyBehavior.Fly();
        }
        
        public virtual void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            if (flyBehavior == null)
            {
                Console.WriteLine("Fly behavior cannot be null.");

                return;
            }

            FlyBehavior = flyBehavior;
        }

        public virtual void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            if (quackBehavior == null)
            {
                Console.WriteLine("Fly behavior cannot be null.");

                return;
            }

            QuackBehavior = quackBehavior;
        }

        public virtual void SetSwimBehavior(ISwimBehavior swimBehavior)
        {
            if (swimBehavior == null)
            {
                Console.WriteLine("Swim behavior cannot be null.");

                return;
            }

            SwimBehavior = swimBehavior;
        }

    }
}
