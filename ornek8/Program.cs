using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek8
{
    class Program
    {
        static void Main(string[] args)
        {
            //vücut kitle indeksi hesaplama vki<=18.49 ideal kilonun altında, vki>=18.5 veya vki<= 24.99 ideal kiloda, vki>=25 veya
            //vki<=29.99 ideal kilonun üzerindesin
            //vki= kiloyu boyunun karesine bölme

            Console.WriteLine("Kilonuzu giriniz:");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            double vki =  (kilo/(boy * boy)) ;

            if (vki<=18.49)
            {
                Console.WriteLine("Vücut kitle indeksiniz {0} ideal kilonun altındasınız",vki);
            }
            else if (vki>=18.5 && vki<=24.99)
            {
                Console.WriteLine("Vücut kitle indeksiniz {0} ideal kilodasınız", vki);

            }
            else if (vki>=25 && vki<=29.99)
            {
                Console.WriteLine("Vücut kitle indeksiniz {0} ideal kilonun üzerindesiniz", vki);

            }
            Console.ReadKey();

        }
    }
}
