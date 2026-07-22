using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args) 
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(3,4);
            dortIslem.Cikar(3, 4);

            dortIslem.Topla(10, 5);
            
        }
    }
}