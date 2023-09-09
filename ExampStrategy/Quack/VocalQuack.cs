using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampStrategy.Quack
{
    public class VocalQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("До-ре-ми!");
        }
    }
}
