using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek7
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 sayı alıp karşılaştıracağız büyüktür küçüktür eşittir diye

            Console.WriteLine("Bir tam sayı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir tam sayı daha giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("{0} sayısı {1} sayısından büyüktür",a,b);
            }
            else if (a<b)
            {
                Console.WriteLine("{0} sayısı {1} sayısından küçüktür", a,b);
            }
            else
            {
                Console.WriteLine("Sayılar birbirine eşittir.");
            }
            Console.ReadLine();
        }
    }
}
