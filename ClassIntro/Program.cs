using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Umut";
            string soyadi = "Kalkan";
            int yasi = 23;

            Kurs kurs1 = new Kurs();         //kurs1 değişkenimizin tipi Kurs'tur. Önceki örneklerde kurs1'in tipini string olarak tanımlamıştık.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 48;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Yılmaz";
            kurs2.IzlenmeOrani = 69;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Ak";
            kurs3.IzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };       //Kurs'u biz bir değişken tipi(string, int) gibi tanımlayabiliriz. 

            foreach (var kurs in kurslar)                             // buradaki kurs aliastır. yani takma addır. buraya x veya başka bir şeyde yazabilirsin
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }    //prop yaz tab'a tıkla
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }   //bunlar kursumuzun özellikleridir


    }
}