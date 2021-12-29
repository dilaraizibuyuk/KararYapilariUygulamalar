using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariUygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //vize ve final notu olan öğrencinin geçme kalma durumu.
            //vizenin %40 ının  finalinin %60ının ortalamasını bul ortalama 50ye eşit ve büyükse geçmiştir değilse kalmıştır.
            Console.WriteLine("Lütfen vize notunu giriniz:");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen final notunu giriniz:");
            int final = Convert.ToInt32(Console.ReadLine());
            double ortalama = ((vize * 0.4) + (final * 0.6));

            if (ortalama >= 50)
            {
                //Console.WriteLine("Dersten Geçtiniz.");
                Console.WriteLine("Ortalamanız {0} dersten geçtiniz",ortalama);
            }
            else
                // Console.WriteLine("Dersten Kaldınız.");
                Console.WriteLine("Ortalamanız {0} dersten kaldınız", ortalama);

            Console.ReadKey(); 


        }

        
    }
}
