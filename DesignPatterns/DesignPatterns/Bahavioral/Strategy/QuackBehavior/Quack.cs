namespace Strategy.QuackBehavior
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            System.Console.WriteLine("Quacking like a regular duck :)");
        }
    }
}
