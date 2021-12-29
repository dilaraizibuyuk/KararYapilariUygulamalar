using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen sayının negatif mi pozitif mi 0a eşit mi olduğuna bakılacak

            int sayi;
            Console.WriteLine("Lütfen bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi==0)
            {
                Console.WriteLine("Sayı 0'a eşittir.");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı negatiftir.");

            }
            else
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            Console.ReadLine();

        }
    }
}
