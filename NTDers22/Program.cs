using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTDers22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int sayi = 1;
                for (int j = 0; j <= i; ++j)
                {
                    a[i] += sayi;
                    ++sayi;
                }
                Console.WriteLine("a Arrayinin"+(i+1)+".elemanı ="+a[i]);
            }
            Console.ReadKey();
        }
    }
}
