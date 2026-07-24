using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //classlar ikiye ayrılır: varlık ve operasyon classları.
    //varlık classları özellikleri tutar, operasyon classları ise metotları tutar.
    //özellikler ve metotlar aynı class içerisinde tutulmaz.

    //manager sınıfları iş sınıflarıdır   //business classes
    internal class MusteriManager
    {
        //Gerçek ve tüzel müşteriyi de buraya(Musteri classına) dahil etmek için miras alıyoruz.
        public void Ekle(Musteri musteri)
        {

        }

        //eğer senin bir base(ebeveyn) sınıfın varsa o base sınıf referans tutucudur.
        //yani hem gerçek hem de tüzel müşteriyi tutabilir.
    }
}
