using System;
namespace MANAVCI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoşgeldiniz");
            Console.WriteLine("Rüya Manavında Fiyatlar Bütçe Dostu!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Çilek = 2TL");
            Console.WriteLine("Diğer Tüm Meyveler = 4 TL");
            Console.WriteLine("Hangi Meyvayı Satın Almak İstersiniz?");
            string meyve = Console.ReadLine().ToLower().Trim();

            if (meyve == "elma")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2TL dir.");
            }
            else if (meyve == "armut")
            {
                Console.WriteLine("seçtiginiz meyvenin fiyatı 3 tl dir.");
            }
            else if (meyve == "çilek")
            {
                Console.WriteLine("Seçtiginiz meyvenin fiyatı 2 tl dir");
            }
            else if (meyve == "muz")
            {
                Console.WriteLine("seçtiginiz meyvenin fiyatı 3 TL dir.");
            }

            else if (meyve == "diger")
            {
                Console.WriteLine("diğer tüm meyveler 4 tl dir.");
            }
            else
                Console.WriteLine("Afiyet Olsun");
        }
    }
}