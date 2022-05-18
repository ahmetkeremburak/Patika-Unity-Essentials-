using System;

namespace While_Foreach_Donguleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1'den girilen sayıya kadar olan sayıları toplayıp ortalamasını alan while döngüsü
            Console.Write("Bir sayı alalım: ");
            int input = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= input)
            {
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine("Ortalama: " + toplam/input);

            //'a'dan 'z'ye kadar tüm harfleri konsola yazdır.

            char character = 'a';

            while (character <= 'z')
            {
                Console.Write(character);
                character ++;
            }

            //Foreach
            // Evvela bir liste tanımlayalım, bu liste içinde işlem yapacağız.

            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
