using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Daire-- > seç1-- > satılık daire / kiralık daire--->50.000tl(satılık için bütçe 50.000den büyükse satın alabilirsin küçükse alamazsın) 
            /// 1000tl(kiralık için bütçen 1000tlden küçükse alamazsın büyükse alabilirsin)
            //2.Villa-- > seç2-- > satılık villa / kiralık villa--->500.000tl
            //(satılık için bütçe 500.000 tlden büyükse satın alabilirsin küçükse satın alamazsın) / 
            //100.000tl(kiralık için bütçe 100.000tlden büyükse kiralayabilirsin küçükse kiralayamazsın)

            Console.WriteLine("İşlem yapmak istediğiniz konut türünü seçiniz:");
            Console.WriteLine("1= Daire  2= Villa");

            int secim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem yapmak istediğiniz kategoriyi seçiniz:");
            Console.WriteLine("1= Satılık    2= Kiralık");

            int islem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bütçenizi giriniz:");

            int butce = Convert.ToInt32(Console.ReadLine());


            if (secim == 1)
            {
                
                if (islem == 1)
                {
                    if (butce > 50000)
                    {
                        Console.WriteLine("Bütçeniz satın alma işlemi için yeterlidir.");
                    }
                    else
                        Console.WriteLine("Bütçeniz satın alma işlemi için yetersizdir.");
                }
                else if (islem == 2)
                {
                    if (butce < 1000)
                    {
                        Console.WriteLine("Bütçeniz kiralama işlemi için yetersizdir.");
                    }
                    else
                        Console.WriteLine("Bütçeniz kiralama işlemi için yeterlidir.");
                }


            }

            if (secim == 2)
            {
                
                if (islem == 1)
                {
                    if (butce > 500000)
                    {
                        Console.WriteLine("Bütçeniz satın alma işlemi için yeterlidir.");
                    }
                    else
                        Console.WriteLine("Bütçeniz satın alma işlemi için yetersizdir.");
                }
                else if (islem == 2)
                {
                    if (butce > 100000)
                    {
                        Console.WriteLine("Bütçeniz kiralama işlemi için yeterlidir.");
                    }
                    else
                        Console.WriteLine("Bütçeniz kiralama işlemi için yetersizdir.");
                }


            }


            Console.ReadLine();

        }
    }
}
