using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer r = new Randomizer(10,2);
            Console.WriteLine(r.GetRandomFromRangeContracted(1, 2));
            Console.WriteLine(r.GetRandomFromRange());
            r.GetRandomFromRange();
            
            Console.ReadLine();
        }
    }
}
