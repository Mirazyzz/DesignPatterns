using Strategy.Duck;
using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using Strategy.SwimBehavior;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDuck mallardDuck = new MallardDuck("cute mallard", 24.5, 50, new FlyNoWay(), new MuteQuack(), new SwimUnderWater());

            mallardDuck.Display();
            mallardDuck.Fly();
            mallardDuck.Swim();
            mallardDuck.Quack();
        }
    }
}
