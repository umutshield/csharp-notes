using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)    //sepete ürünü nereden ekleyeceğimizi belirtmek için bir parametre kullanarak bunu belirtmeliyiz 
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat )
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
