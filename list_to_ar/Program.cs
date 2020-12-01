using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_to_ar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theArray = {3, 5, 4, 1, 2, 6};
            // methods : len , indexOf , Bsort_desc,Bsort_asc,Addvalue,RemoveValue

            int[] bs = Class1.RemoveValue(theArray,7);
            foreach(int x in bs)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();

        }
    }
}
