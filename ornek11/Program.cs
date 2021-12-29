using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {     
        static void Main(string[] args)
        {   //1) bir firma 2 adet servis paket sunuyor. şartlar :
            //1.müşteri bütçesi en az 1500 tl olmalı
            //2.1500 - 2500 tl bütçe ise a paketini alabiliyor.
            //3.2500 tl ve üzerinde ise hem a hem b paketini alabiliyor

            Console.WriteLine("Paket işlemleri için bütçenizi giriniz:");
            int butce = Convert.ToInt32(Console.ReadLine());

            if (butce < 1500)
            {
                Console.WriteLine("Malesef bütçeniz yetersiz..");
            }
            else if (butce >= 1500 && butce < 2500)
            {
                Console.WriteLine("Bütçeniz A paketini almanıza imkan sağlıyor.");
            }
            else if (butce >= 2500)
            {
                Console.WriteLine("Bütçenize göre A ya da B paketinden yararlanabilirsiniz.");
            }
            Console.ReadLine();
        }
    }
}
