using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
