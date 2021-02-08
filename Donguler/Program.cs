using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {   
                "Kurs1","Kurs2","Kurs3","Kurs4","Kurs5"
            };
            //for (int i = 0; i<kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
