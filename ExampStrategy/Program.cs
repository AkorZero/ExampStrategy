using ExampStrategy.Duck;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<DuckBase> ducks = new List<DuckBase>();
        ducks.Add(new SimpleDuck());
        ducks.Add(new ExoticDuck());

        foreach (var duck in ducks)
        {
            duck.Display();
            duck.quackBehaviour.Quack();
            duck.flyBehaviour.Fly();
            Console.WriteLine("");
        }

    }
}