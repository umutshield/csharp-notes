using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //miras (inheritance)    //tüzel müşteri bir müşteridir. müşteriden miras aldık.
    //yani şu anlama gelir: müşteride olan özellikler tüzeldede gerçektede vardır
    internal class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
} 
