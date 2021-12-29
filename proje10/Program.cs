using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje10
{
    class Program
    {
        static void Main(string[] args)
        { //2 ürün var. 1 ürün alana 2. ürün %25 indirimli. ama 2 ürünün tutarı 200 tden büyükse indirim uygulanacak tutar da ekrana yazılacak
            Console.WriteLine("1. ürünün fiyatı nedir?");
            int urun1_fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. ürünün fiyatı nedir?");
            int urun2_fiyat = Convert.ToInt32(Console.ReadLine());
            int tutar = urun1_fiyat + urun2_fiyat;
            int indirim = ((urun2_fiyat * 75) / 100 );
            int indirimli_tutar = indirim + urun1_fiyat;
            if (urun1_fiyat+urun2_fiyat>=200)
            {
                
            Console.WriteLine("Toplam tutarınız 200 TL'yi geçtiği için 2. üründen %25 indirim kazandınız.Alışveriş tutarınız {0} TL'den {1} TL'ye inmiştir. " ,tutar,indirimli_tutar);

            }
            else if (tutar<200)
            {
                Console.WriteLine("Alışveriş tutarınız {0} TL'dir",tutar);
            }
            
            Console.ReadKey();
            
        }
    }
}
