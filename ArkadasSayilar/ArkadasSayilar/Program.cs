using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadasSayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam1 = 0, toplam2 = 0,i;
            Console.WriteLine("Birinci sayıyı giriniz");
            sayi1= int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            sayi2= int.Parse(Console.ReadLine());

            for (i = 1; i < sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    toplam1 = toplam1 + i;
                }
            }
            for (i = 1; i < sayi2; i++)
            {
                if (sayi2 % i == 0)
                {
                    toplam2 = toplam2 + i;
                }
            }

            if (sayi1 == toplam2 && sayi2 == toplam1)
            {
                Console.WriteLine("Girilen sayılar arkadaş sayı");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girilen sayılar arkadaş sayı değil");
                Console.ReadLine();
            }
        }
    }
}
