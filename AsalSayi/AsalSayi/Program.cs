using System;

namespace AsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Kontrol etmek istediğiniz sayıyı Girin :");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }
        }
    }
}