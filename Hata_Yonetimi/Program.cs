using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
        //    try
        //    {
        //        Console.WriteLine("Bir sayı giriniz: ");
        //        int sayi = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Girilen sayı: " + sayi);
        //    }

        //    catch(Exception ex)
        //    {
        //        Console.WriteLine("Hata: " + ex.Message.ToString());
        //    }

        //    finally
        //    {
        //        Console.WriteLine("İşlem tamamlandı.");

        //    }

            try
            {
                // int a = int.Parse(null);
                // int b = int.Parse("yanlış veri tipi.");
                int c = int.Parse("-200000000000");
            }

            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);

            }

            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uyuşmuyor.");
                Console.Write(ex);
                    
            }

            catch(OverflowException ex)
            {
                Console.WriteLine("Aşırı büyük veya aşırı küçük bir sayı girildi.");
                Console.WriteLine(ex);
            }
            
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
