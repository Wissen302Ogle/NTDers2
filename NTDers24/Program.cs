using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTDers24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sipariş Adedi =");
            int miktar = Convert.ToInt32(Console.ReadLine());
            int birim = 100;
            double tutar=0;
            if (miktar > 0)
            {
                if (miktar < 20)
                {
                    tutar = miktar * birim;
                    Console.WriteLine("İndirim yok..Ödenecek tutar = " + tutar);

                }
                else if (miktar >= 20 && miktar < 50)
                {
                    tutar = miktar * (birim - ((birim * 5) / 100));
                    Console.WriteLine("Ödenecek tutar = " + tutar);
                }
                else if (miktar >= 50 && miktar < 100)
                {
                    tutar = miktar * (birim - ((birim * 10) / 100));
                    Console.WriteLine("Ödenecek tutar = " + tutar);
                }
                else if (miktar >= 100 && miktar < 200)
                {
                    tutar = miktar * (birim - ((birim * 25) / 100));
                    Console.WriteLine("Ödenecek tutar = " + tutar);
                }
                else
                {
                    birim = 50;
                    tutar = miktar * birim;
                    Console.WriteLine("Ödenecek tutar = " + tutar);

                }
                Console.ReadKey();

            }
            else
                Console.WriteLine("Hatalı giriş");
            Console.ReadKey();

        }
    }
}
