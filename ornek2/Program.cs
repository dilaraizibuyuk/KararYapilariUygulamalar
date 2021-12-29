using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı adı ve şifresini isteyip kontrol ettirip mesaj ver
            string kadi, sifre;
            Console.WriteLine("Kullanıcı adını giriniz:");
            kadi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            sifre = Console.ReadLine();

            if (kadi=="admin"&& sifre=="123")
            {
                Console.WriteLine("Giriş işlemi başarıyla yapıldı.");

            }
            else
                Console.WriteLine("Kullanıcı adı ya da şifre hatalı");
            Console.ReadLine();


        }
    }
}
