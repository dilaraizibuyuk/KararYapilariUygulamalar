using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek9
{
    class Program
    {
        static void Main(string[] args)
        {
            //toplam tutarı yazdırıcaz tt kullanıcıdan alınacak. tt<100 ise ekstra 6tl öde tt>=100 ise tt 100 yazdır

            Console.WriteLine("Toplam tutarı giriniz:");
            int tutar = Convert.ToInt32(Console.ReadLine());
            int ekleme = 100 - tutar;
            if (tutar>=100 || tutar==0)
            {
                Console.WriteLine("Toplam tutar {0} TL'dir.",tutar);
            }
            else
            Console.WriteLine("Toplam tutar {0} TL'dir. Ekstra 6 TL ödememek için en az {1} TL'lik daha ürün ekleyiniz. ", (tutar+6),ekleme);
            Console.ReadKey();
        }
    }
}
