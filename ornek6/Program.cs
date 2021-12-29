using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek6
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayının karesi,küpünü ve karakökünü hesapla

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlemi seçiniz:");
            double kare, kup, kok;
            
            
            Console.WriteLine("1=kare alma , 2=küp alma, 3=kök alma");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine(kare = sayi * sayi);

            }
            else if (secim==2)
            {
                Console.WriteLine(kup = sayi * sayi * sayi);
            }
            else if(secim==3)
                Console.WriteLine(kok = Math.Sqrt(sayi));                

            else
                Console.WriteLine("Doğru seçim yapınız");

            Console.ReadLine();

        }
    }
}
