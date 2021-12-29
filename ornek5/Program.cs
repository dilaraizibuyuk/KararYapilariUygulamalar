using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden sıcaklık girilecek katı,sıvı,gaz mı bakılacak

            Console.WriteLine("Suyun sıcaklık değerini giriniz:");
            double sicaklik = Convert.ToDouble(Console.ReadLine());
            //int sicaklik = Convert.ToInt32(Console.ReadLine());

            if (sicaklik<=0)
            {
                Console.WriteLine("Su katı haldedir");
            }
            else if (sicaklik>=100)
            {
                Console.WriteLine("Su gaz halindedir.");
            }
            else
                Console.WriteLine("Su sıvı haldedir");
                Console.ReadKey();
        }
    }
}
