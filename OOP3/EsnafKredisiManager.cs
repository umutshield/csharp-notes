using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Biz yeni bir kredi eklemek istersek direkt solution explorer'a gelir ve yeni bir sınıf ekleriz.
    //sonra bu sınıfı IKrediManager interface'inden implement ederiz. 
    //aynı şekilde bir logger eklemek istersek yeni bir sınıf oluşturur ve onu da ILoggerService interface'inden implement ederiz.
    //buradaki temel mantık SOLID prensiplerinden O harfi olan Open Closed Principle'a uymaktadır.
    //Yani mevcut kodu değiştirmeden yeni bir özellik ekleyebiliyoruz (tek bir sayfada iflerle falan uğraşmayız).
    internal class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }
    }
}
