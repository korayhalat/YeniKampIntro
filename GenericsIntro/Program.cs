using System;

namespace GenericsIntro
{
    class Program //
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Koray");
            Console.WriteLine(isimler.Lenght);

            isimler.Add("Burçin");
            Console.WriteLine(isimler.Lenght);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }


        }
    }
}
