namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id=2, CategoryId=5, 
                ProductName="Kalem", UnitPrice=35, UnitInStock=5 };

            //string isim;  == ProductManager productManager;   aynı şeyler veri tipi ve veri adı

            //class örneğini inceleyim: ProductManager veri tipidir tıpkı string gibi, productManager ise veri adıdır,  
            //productManager yerine x veya başka bir şeyde yazabilirsin. bizim classımızın referans tipli olması ve heap belleğinde
            //tutulması için new ProductManager() yazıyoruz. new dediğimizde bellekte bir yer açılıyor ve o classın referansını tutuyor.

            //PascalCase   //camelCase  classlar büyük harfle başlar, class adı ise küçük harfle başlar   
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

        }
    }
} 
