using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //burada T, generic tip olarak kullanılıyor. Bu sayede MyList sınıfı herhangi bir tip ile çalışabilir.
    //önceki örneklerde örneğin List<string> yazmıştık, bu şekilde olursa listede sadece string yazabiliriz.
    //ama T kullanırsak istediğimiz veri tipini kullanabiliriz.
    class MyList<T>     
    {
        T[] items;
        //constructor: bir class newlendiği zaman çalışan bloktur.
        public MyList()
        {
            items = new T[0];                //items dizisini 0 elemanlı yaptık 
        }
        public void Add(T item)
        {
            T[] tempArray = items;           //biz bir alt satırda yeni new oluşturduğumuzda eski elemanları
                                             //kaybetmemek için geçici olarak tempArray'e atıyoruz.
            items = new T[items.Length+1];   //dizinin eleman sayısını bir arttırır
            for (int i = 0; i < tempArray.Length; i++)   //tempArray'e attığımız elemanları items'a geri aldık
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;   //son elemanı ekledik
        }
    }
}