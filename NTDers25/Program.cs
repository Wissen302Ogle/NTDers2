using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NTDers25
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Bom");
                    Thread.Sleep(200);
                }
                else
                {
                    Console.WriteLine(i);
                    Thread.Sleep(200);
                }

            }
            Console.ReadKey();
        }
    }
}
