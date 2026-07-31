using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Looger service sistemdeki hareketleri kaydetmek için kullanılır. Bu loglama işlemi bir dosya, veritabanı veya sms olabilir.
    interface ILoggerService
    {
        void Log();
    }
}
