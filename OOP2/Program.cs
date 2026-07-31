namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo= "12345";
            musteri1.Adi = "Umut";
            musteri1.Soyadi = "Kalkan";
            musteri1.TcNo= "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Burada musteri1 gerçek bir müşteri olduğu için şirket adı yoktur. şirket adı tüzel müşterilere
            //geçerli olduğu için tüzel müşteriler adına ayrı bir class oluşturulmalıdır.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //new görürsün o referans numarasıdır. 
            //Musteri class'ı hem GerçekMusteri hem de TüzelMusteri class'larının referansını tutabilir.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
        }
    }
} 
