using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NTDers27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kat =");
            int kat = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 1)
                {
                    if (i % kat != 0)
                    { Console.WriteLine("Pc :" + i); }
                    else
                    {
                        Console.WriteLine("Bom");
                    }
                }
                else
                {
                    if (i % kat != 0)
                    {
                        Console.Write("Kullanıcı :");
                        Console.ReadLine();
                    }
                    else
                    {
                        string girdi = Console.ReadLine();
                        if (girdi != "Bom")
                        {
                            Console.WriteLine("Pc Kazandı..!");

                            Console.ReadKey();
                            break;
                        }

                    }
                }


            }
        }
    }
}
