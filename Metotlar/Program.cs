using System;

namespace Metotlar

    // metotlar, dont repeat your self mantığıyla çalışır. yani bir kodu birden fazla kez/yerde yazmak yerine bir kez yazıp birden fazla yerde
    // kullanılabilir hale getirir.
    
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();        //bu bir class örneğidir
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };     //gerçekte parantez içinde yazdığımız urun1 urun2'ler bir veri kaynağından direkt çekilir

            //foreach kısmını detaylı inceleyelim
            //ilk Urun bizim veri tipimizdir. veri güvenliği(type safe) için bunu yazmak zorundayız
            //çünkü program hangi veri tipiyle çalıştığımızı bilmek istiyor. direkt Urun yerine var da yazabilirsin
            //ikinci urun kısmı ise bizim alias yani takma adımızdır. foreach döngüsü tek tek ürünleri döndüğünde urun önce 1.ürünü sonra 2.ürünü gezer
            //ve bu döngü böyle devam eder
            //son kısım urunler ise dizimize aittir. yani biz verileri urunler dizisinden çektiğimiz için bunu ifade eder
            
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------------Metotlar------------------");

            //bir instance daha - class örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //kodları genellikle aşağıdaki şekilde yazmayız. bu ürünlerin her birini farklı sayfadaymış gibi düşün. sonra yönetici bize dediki bu özelliklere
            //ek olarak stok adedini de ekle. sen stok adedini eklemek istediğin zaman önce SepetManager sınıfına gelir Ekle2 metoduna eklersin bu özelliği.
            //sonrasında ise tek tek aşağıdaki ürünlere eklemek zorunda kalırsan. bu yüzden çok fazla işlem yapıldığı için metotları aşağıdaki gibi kullanmayız
            //üstteki gibi kullandığımız zaman yapacağımız tek şey Urun sınıfına gelip yeni bir property eklemek. otomatik olarak bu property Urun'e eklenir.
            //bu olaya encapsulation (kapsülleme) denir. yani ayrı ayrı yazacağın yapıları bir düzenin/kapsülün içine sokuyorsun.

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);

        } 
    }
}