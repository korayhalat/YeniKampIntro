using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro //
{    
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];   // yukarda oluşturduğumuz items dizisini.Constructer altında
        }                       // eleman sayısını direkt sıfırlıyoruz.
        public void Add(T item)
        {
            T[] tempArray = items;              //items dizisini oluşturduktan s
                                                //onra referans numarasını tutmak için bu diziyi oluşturmaşlıyız.

            items = new T[items.Length + 1];    //Buradaki +1 dizi eleman için alan oluşturmak için
                                                //yer oluşturuyoruz.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; 
            }
            items[items.Length - 1] = item; //item.Lenght -1 dememizin sebebi,uzunluk değeri ile dizi indexi
                                            //1 eksiği olduğu için cıkarma işlemini yapıyoruz.
        }
        public int Lenght
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }











    }
}
