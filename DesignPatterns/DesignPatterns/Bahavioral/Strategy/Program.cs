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
            // Initializing mallard duck
            BaseDuck duck = new MallardDuck("Cute john", new FlyRocketPowered(), new Squeak(), new SwimUnderWater());

            duck.Display();
            duck.Fly();
            duck.Quack();
            duck.Swim();
            System.Console.WriteLine();

            // Changing duck's fly, quack, swim behaviors
            duck.SetFlyBehavior(new FlyWithWings());
            duck.SetQuackBehavior(new MuteQuack());
            duck.SetSwimBehavior(new SwimWithBoat());

            duck.Display();
            duck.Fly();
            duck.Quack();
            duck.Swim();
            System.Console.WriteLine();

            // reassining duck to another subtype with new behaviors
            duck = new RubberDuck("Toy Steve", new FlyNoWay(), new Quack(), new SwimUnderWater());
            duck.Display();
            duck.Fly();
            duck.Quack();
            duck.Swim();
        }
    }
}
