using ExampStrategy.Fly;
using ExampStrategy.Quack;

namespace ExampStrategy.Duck
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            this.flyBehaviour = new NoFly();
            this.quackBehaviour = new VocalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Не просто утка. Отобрали шляпу.");
        }
    }
}
