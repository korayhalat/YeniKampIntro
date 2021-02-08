using System;
using System.Collections.Generic;

namespace Dictionary_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> motorAdi = new List<string>();
            motorAdi.Add("Kawasaki");
            motorAdi.Add("Yamaha");
            motorAdi.Add("Honda");
            motorAdi.Add("Bajaj");
            motorAdi.Add("Suzuki");
            motorAdi.Add("Mondial");

            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Kawasaki");
            myDictionary.Add("Yamaha");
            myDictionary.Add("Honda");
            myDictionary.Add("Bajaj");
            myDictionary.Add("Suzuki");

            Console.WriteLine(motorAdi.Count);
        }
    }
}
