 namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999   ikisi arasındaki fark nasıl oldu?

            //int, float, decimal, bool = değer tip
            //array, class, interface = referans tip
            //bellekte stack ve heap adında 2 bellek vardır. değer tipli olanların işlemleri stack belleğinde gerçekleşir.
            //referans tipli olanlarsa heap belleğinde işlemleri yapar. sayilar1 değişkeni stackte belleklenir fakat değerleri
            //heap belleğindedir. bu ikisi arasındaki bağlantı adres değeri/numarası ile sağlanır. asıl olay burada işte
            //sen sayilar1'i sayilar2'ye eşitlediğin zaman bu şu anlama geliyor: sayilar1'in referans numarası sayilar2'nin
            //referans numarasına eşittir. özet olarak stack belleğinde eşitleme işlemi değişkenler üzerinden gerçekleşirken
            //heap belleğinde ise eşitleme işlemi refernas(adres) numarası üzerinden gerçekleşir.
        }
    }
} 
