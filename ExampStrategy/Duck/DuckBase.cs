using ExampStrategy.Fly;
using ExampStrategy.Quack;

namespace ExampStrategy.Duck
{
    public abstract class DuckBase
    {
        public IFly flyBehaviour;
        public IQuack quackBehaviour;

        protected DuckBase()
        {
            this.flyBehaviour = new SimpleFly();
            this.quackBehaviour = new SimpleQuack();
        }

        public abstract void Display();

    }
}
