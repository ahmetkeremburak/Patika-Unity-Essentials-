using System;

namespace Diziler
{
    public class Program 
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Kertenkele" };

            int[] dizi;

            dizi = new int[5];

            // Dizilere Değer Atama ve Erişim
            
            renkler[0] = "mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle Dizi Kullanımı

            // Kullanıcıdan alınan sayılarla oluşturulan sayı dizisinin elemanları ortalaması

            Console.WriteLine("Dizinin eleman sayısını giriniz: ");
            int dizi_uzunluğu = int.Parse(Console.ReadLine());
            int[] sayi_dizisi = new int[dizi_uzunluğu];

            for (int i = 0; i < dizi_uzunluğu; i++ )
            {
                Console.WriteLine("Lütfen dizinin {0}.sayısını giriniz: ", i+1);
                sayi_dizisi[i] = int.Parse(Console.ReadLine());
            }
            
            int toplam = 0;

            foreach (var sayi in sayi_dizisi)
            {
               toplam += sayi; 
            }
            
            Console.WriteLine("Sayıların ortalaması: " + toplam/dizi_uzunluğu);

        }
        
    }
}
