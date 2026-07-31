namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            //burada ihityac, tasit, konutmanager'lerin yerine IKrediManager interface'ini kullanabiliriz.
            //bu şu demektir: interface onu implement eden classların referansı tutabilir.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), 
                new List<ILoggerService>{new DatabaseLoggerService(), new FileLoggerService() });
            
            //burada direkt new ile classları yazdık. yukarı satırlarda instance de oluşturabilirdik. fark etmiyor yani.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //aslında bu liste örneği yukarıdaki BasvuruYap örneği ile hemen hemen aynı örnektir. aralarındaki fark 
            //birinde tek bir kredi türü ile işlem yapılırken diğerinde birden fazla kredi türü ile işlem yapılmasıdır.
        }
    }
} 
