using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }    //eğerki sayısal bir işlem yapmıyorsun bazı sayısal değerleri string olarak tutabilirsin
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
