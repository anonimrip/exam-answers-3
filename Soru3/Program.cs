using System;
//ER3N
namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aylar = new string[12];
            int sayac = 1;
            for(int i=0;i<12;i++)
            {
                Console.Write(sayac+". Ayı Giriniz: ");
                sayac++;
                aylar[i] = Console.ReadLine();

            }

            Console.WriteLine();
            Console.WriteLine();
            for (int c=0;c<aylar.Length;c++)
            {
                Console.WriteLine("Dizeye Aktarılan Değer: "+aylar[c]);
            }

            Console.ReadKey();
        }
    }
}
