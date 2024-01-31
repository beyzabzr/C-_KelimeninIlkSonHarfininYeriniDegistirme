using System;
namespace KelimeninIlkVeSonHarfiniDegistirme
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Kaç kelime gireceksiniz? ");
                int kelimeSayisi = Convert.ToInt32(Console.ReadLine());
                string[] kelimeler = new string[kelimeSayisi];

                for (int i = 0; i < kelimeSayisi; i++)
                {
                    Console.Write($"{i + 1}. kelimeyi girin: ");
                    kelimeler[i] = Console.ReadLine();
                }

                KelimeleriDegistir(kelimeler);

                Console.WriteLine("Kelime Listesi (İlk ve Son Harfin Yeri Değiştirilmiş):");
                foreach (var kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }
            }

        }
        public static void KelimeleriDegistir(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 2)
                {
                    char ilkHarf = words[i][0];
                    char sonHarf = words[i][words[i].Length - 1];

                    // Kelimenin ilk ve son harfinin yerini değiştir
                    char[] kelimeDizi = words[i].ToCharArray();
                    kelimeDizi[0] = sonHarf;
                    kelimeDizi[words[i].Length - 1] = ilkHarf;

                    // Değiştirilmiş kelimeyi array içinde güncelle
                    words[i] = new string(kelimeDizi);
                }
                else
                {
                    Console.WriteLine($"Kelime {i + 1} en az iki karakter içermelidir.");
                }
            }
        }

    }
}

