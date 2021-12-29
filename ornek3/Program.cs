using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen sayının çift mi tek mi olduğunu bulma
            int sayi;
            Console.WriteLine("Lütfen bir sayı giriniz:");
            sayi =Convert.ToInt32( Console.ReadLine());

            if (sayi%2==0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            Console.WriteLine("Girdiğiniz sayı tektir.");
            Console.ReadLine();
        }
    }
}
