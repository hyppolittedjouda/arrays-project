using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] xs = new int[7] {1, 2, 3, 4, 5, 6, 7};
            var xs = new List<string>() { "cats", "dogs", "horses", "pigs" };

            
          for ( int i=0; i< xs.Count -1; ++i)
            {
                xs[i] = xs[i + 1];
            }


            foreach (var x in xs)
            {
                Console.WriteLine(x);
            }
        }
    }
}
