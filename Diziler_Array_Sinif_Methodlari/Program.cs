using System;

namespace Diziler_Array_Sinif_Methodlari
{
    public class Program 
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayi_dizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("*******Sırasız Dizi*******");

            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }
        }   
    }
}