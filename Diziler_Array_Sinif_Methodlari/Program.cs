using System;

namespace Diziler_Array_Sinif_Methodlari
{
    public class Program 
    {
        static void Main(string[] args)
        {
            //Sort - Dizi elemanlarını küçükten büyüğe doğru sıralar
            int[] sayi_dizisi = {23,12,4,86,72,3,11,17};
            
            Console.WriteLine("*******Sırasız Dizi*******");

            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("*******Sıralı Dizi******");

            Array.Sort(sayi_dizisi);
            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear - Verilen endekslere göre elemanları sıfırlar

            Console.WriteLine("*******Array Clear*******");

            //İkinci indeksten itibaren 2 elemanı sıfırlar
            Array.Clear(sayi_dizisi,2,2);

            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse - Diziyi tersine çevirir. Son eleman başa,baştaki sona. Ortadan aynalanmış gibi.

            Console.WriteLine("*******Array Reverse******");

            Array.Reverse(sayi_dizisi);

            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf - Giriln değer hangi indexte onu verir

            Console.WriteLine("*******Index of Array*******");

            Console.WriteLine(Array.IndexOf(sayi_dizisi,23));

            //Resize - Arrayi belirtilen boyuta getirir

            Console.WriteLine("*******Array Resize*******");

            // 8 elemanlı arrayimizi 9 elemanlı yapıp son elemanına '99' sayısını atıyoruz
            Array.Resize<int>(ref sayi_dizisi,9);
            sayi_dizisi[8] = 99;

            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }
        }   
    }
}