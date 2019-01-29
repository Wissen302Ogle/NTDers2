using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 1;
            Console.WriteLine("Array'in 1.elemanı ="+a[0]);
            for (int i = 1; i < 5; i++)
            {
                a[i] = a[i-1] + i + 1;
                Console.WriteLine("Array'in " + (i+1) + ".elamanı =" + a[i]);
                
            }
            Console.ReadKey();
        }
    }
}
