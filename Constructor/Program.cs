namespace Constructor
{
    //constructor nedir?
    //constructor, bir nesne oluşturulduğunda( new ClassAdi() ) çağrılın bir metottur. buradaki parantez bir metotu tetikler ve o metotta constructor metottur.
    //constructor metot, nesne ilk ayağı kaldırılırken o nesneye ait ilk işlemleri yaptığımız metottur. 
    //bir sınıftan nesne üretirilken bu sınıfın içinde belli konfigürasyonlar şu şekilde olsun, nesne üretildiğinde o
    //konfigürasyonların sana gelmesini istiyorsan ve bunların için extra bir fonksiyon üretmemek istiyorsan bu işlemleri constructor metot ile yapabilirsin.
    //constructor, nesne oluşturma sürecinde tetiklenmek zorundadır!
    //özetle constructor, nesneye dair konfigürasyonları yapabileceğimiz bir metottur. illaki ilk işlemleri yapmak zorunda değiliz yani.

    //constructor metot nasıl oluşturulur?
    //constructor, özel bir sınıf elemanıdır. özel olsada bir metottur! 
    //bildiğimiz metotlardan biraz farklıdır. nasıl?
    //constructorların; 1- metot adı sınıf adıyla aynı olmalıdır!
    //2- geri dönüş değeri olmaz.
    //3- erişim belirleyicisi public olmalıdır.

    //default constructor
    //her sınıfın içerisinde tanımlamasak bir default constructor mevcuttur.
    //eğerki classa constructor eklersek default constructor'ı ezmiş oluruz.

    //parametreli constructor
    //constructorlar parametre alabilirler. 

    //constructor overload
    //constructor overload edilebilir. overload demek bir ismi birden fazla kez tanımlamak/kullanmaktır. bu tanımlamanın olması için
    //constructorların imza yapıları aynı fakat nitelikleri farklı olmalıdır. yani parametreler aynı olmamalıdır.

    //constructor'ın erişim belirleyicisi private olursa ne olur?
    //constructor'ın erişim belirleyicisi private olursa nesne üretilirken o sınıfın constructor'ına erişim sağlanmadığı için nesne üretilemez.
    
    //this keyword'üyle constructorlar arası geçiş
    //bir sınıfta birden fazla overloading yaparak constructor tanımladığımızda herhangi bir constructor üzerinden sınıftan nesne inşa ederken
    //farklı constructorlarında tetiklenmesini isteyebiliriz işte bu yüzden this keyword kullanılır.
    //this keyword sınıfın o anki içindeki nesnesini temsil eder.
    public class Prgoram
    {
        static void Main(string[] args)
        {
            new MyClass(3);
            new MyClass("a");


        }
    }

    public class MyClass
    {
        public MyClass(int a)
        {
            Console.WriteLine("Constructor metot çalıştı! " + a);
        }

        public MyClass(string a)
        {
            Console.WriteLine("Constructor metot çalıştı! " + a);
        }

        public void M()
        {

        }
    }

}
