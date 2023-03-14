using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    sayac++;
            }
            if (sayac != 0)
            { Console.WriteLine("Girilen sayı asal değil"); }
            else
            { Console.WriteLine("Girilen sayı asaldır"); }
        
            
            Console.ReadKey();
        }
    }
}
