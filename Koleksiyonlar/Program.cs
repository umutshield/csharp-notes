using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] isimler = new string[] { "Umut","Engin","Murat","Ali" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);   
            */
            
            //BURASI ÖNEMLİ!! bu kodları çalıştırdığımızda son satırdaki isimler[0] null değerini döndürür,
            //çünkü isimler dizisini yeniden oluşturduk ve eski değerini kaybettik(yeni referans adresi oluşturduk).
            //yani bundan sonra sen hangi isimi yazdırmaya çalışırsan yaz, sadece 5.indexteki isimler[4] değerini yazdırır, diğerleri null olur.
            //DİKKAT!! işte gerçek hayatta da biz dizileri bir veri kaynağından çektiğimiz için dizilere yeni bir veri eklemeye çalıştığımızda
            //eski değerleri kaybederiz, bu yüzden diziler yerine koleksiyonları kullanırız. 

            List<string> isimler2 = new List<string> { "Umut", "Engin", "Murat", "Ali" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
