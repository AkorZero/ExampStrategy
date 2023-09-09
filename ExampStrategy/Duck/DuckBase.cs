using ExampStrategy.Fly;
using ExampStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
