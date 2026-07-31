namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();     //liste aslında arkada bir array kullanıyor.
            isimler.Add("Umut");

        }
    }
} 
