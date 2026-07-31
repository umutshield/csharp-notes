using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method injection: BasvuruYap methodunun kullandığı krediyi ve hangi loglayıcı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //!! Burada konut kredisini hesaplanır fakat tüm başvurularda kredi konut kredisi üzerinden hesaplanır. 
            //tüm başvurular konut kredisine bağımlı oldu. 

            //böyle bir sorun yaşamamk için parametre olarak IKrediManager'ı yazarız.
            //çünkü IKrediManager interface'ini implement eden tüm classlar bu parametreyi kullanabilir.

            //birden fazla loglama yapmak istersek ILoggerService'i liste içine alırız.

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)      //bu döngü krediler listesini döndürür ve her kredinin hesabını yapar
            {
                kredi.Hesapla();
            }
        }
    }
} 
