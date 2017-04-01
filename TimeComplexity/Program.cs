using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            decimal y = 100;
            while (x < y)
            {
                x = x + 2;
                y = 0.5M * y;
            }
        }
    }
}
