using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NTDers26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kat giriniz =");
            int kat = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 100; i++)
            {
                if(i % kat == 0)
                {
                    Console.WriteLine("Bom");
                    
                }
                else
                {
                    Console.WriteLine(i);
                    
                }
                Thread.Sleep(250);
            }
            
            Console.ReadKey();
        }
    }
}
