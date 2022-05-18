using System;

namespace For_Loop_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayıya kadar olan tek sayıları yazdır
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());            

            for (int i = 0; i <= sayac; i++)
            {
                if (i%2 == 1)
                    Console.WriteLine(i);
            }
            
            //1'den 1000'e tek ve çift sayıların kendi içlerinde toplanması

            int tek_toplam = 0;
            int cift_toplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i%2 == 0)
                    cift_toplam += i;

                else
                    tek_toplam += i;                
            }

            Console.WriteLine("Çiftlerin Toplamı: " + cift_toplam);
            Console.WriteLine("Teklerin Toplamı: " + tek_toplam);

            // break ve continue

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}


