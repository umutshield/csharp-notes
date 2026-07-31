using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //!! İNTERFACELERİ birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    //KrediManager tek başına bir şeyi ifade etmez. tüm krediler, hesapla metodunu farklı ele alır. 
    //imzanın(void Hesapla) aynı olduğu fakat içerisinin farklı olduğu durumlarda class değil interface kullanılır.
    //eğerki biri bu interface'i kullanırsa bu interface bağlı metotları/şablonu kullanmak zorundadır.
    //özetle IKrediManager bir interface. bu interface bu kuralları(Hesapla, BiseyYap) içerir ve
    //onu implement eden classlar(Tasit, Konut, Ihtiyac) bu kuralları kendine göre doldurmak zorundadır.
    //interface kullanıldığı anlaşılsın diye başına I harfi konulur. (IKrediManager)
    //interfacede sadece imza olur.

    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}