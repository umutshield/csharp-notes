using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //eğerki bir nesnede bir alan o nesneye ait değilmiş gibi duruyorsa orada bir soyutlama hatası vardır.
    //yani burada gerçek ve tüzel müşteriyi tek bir class içerisinde tutmak hatalıdır. ayrı classlarda tutulmalıdır.
    internal class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
