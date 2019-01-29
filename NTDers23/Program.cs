using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTDers23
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden iki adet not giriliyor ortalama 50 ve  üstüyse geçti değilse kaldı 




            string not1;
            do
            {
                Console.Write("1.Notu Giriniz = ");
                not1 = Console.ReadLine();
                while (not1.All(Char.IsDigit) == false)
                {
                    Console.WriteLine("Sayı Giriniz ");
                    not1 = Console.ReadLine();
                }
                int not1_1 = Convert.ToInt32(not1);
                Console.Write("2.Notu Giriniz = ");
                string not2 = Console.ReadLine();
                while (not2.All(Char.IsDigit) == false)
                {
                    Console.WriteLine("Sayı Giriniz ");
                    not2 = Console.ReadLine();
                }
                int not2_2 = Convert.ToInt32(not2);


                double ortalama = (not1_1 + not2_2) / 2;
                Console.WriteLine();
                if (ortalama >= 50)
                    Console.WriteLine("Geçti");
                else
                    Console.WriteLine("Kaldı");


                Console.WriteLine("Başka bir not ortalaması hesaplamak ister misiniz? E/H");
                not1 = Console.ReadLine();
            } while (not1 == "E" || not1 == "e");
            Console.Write("Başka bir hesaplamada görüşmek üzere..");
            Console.ReadKey();







        }
    }
}
