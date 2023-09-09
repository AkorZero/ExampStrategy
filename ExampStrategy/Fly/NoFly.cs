namespace ExampStrategy.Fly
{
    public class NoFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я не умею летать...");
        }
    }
}
