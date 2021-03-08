using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç sayı üretmek istiyorsunuz");
            byte adet = byte.Parse(Console.ReadLine());

            Random rastgele = new Random();

            int[] sayilar = new int[adet];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Klavyeden {0}. sayıyı girin:", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

                int yeniSayi = rastgele.Next(0, 100);
                Console.WriteLine(yeniSayi.ToString());

                if (sayilar.Contains(yeniSayi))
                {
                    i++;
                }
                else
                {
                    sayilar[i] = yeniSayi;
                }

                sayilar[i] = rastgele.Next();
            }
            Array.Sort(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);

            }
        }
    }
}
