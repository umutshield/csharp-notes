using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım geliştirme kampı", "Başlangıç temelleri kampı", "Java Kursu", "C# Geliştirme Kursu" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            // foreach döngüsü

            foreach (string kurs in kurslar)          // buradaki kurs aliastır. yani takma addır. buraya x veya başka bir şeyde yazabilirsin
            {
                Console.WriteLine(kurs);
            }


        }
    }
} 