using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //burada Product product dediğimiz şey aslında string ad gibi bir veri tipidir. Yani Product türünde bir product değişkeni oluşturduk.

        //void ne işe yarar? void, metotları emir kipiyle çalıştırır. git Ekle, git Güncelle gibi. Void değer döndürmez.
        //Eğer bir metot bir değer döndürüyorsa, o zaman void yerine o değerin türü yazılır. Örneğin, int, string, bool gibi.
        //özetle sen void'i bir kere kullandın ve bitti. sayısal bir işlem yapmak istersen örneğin sayi1 ile sayi2'yi topladın
        //ve sonucuyla bir daha işlem yapmak istersen o zaman void değil int ya da double kullanılır.

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        
    }
}
