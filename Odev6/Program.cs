using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductCompany = "Apple";
            product1.ProductName = "iphone";
            product1.ProductModel = "S7";
            product1.ProductPrice = 2500;
            product1.ProductVaranty = 2;

            Product product2 = new Product();
            product2.ProductCompany = "Samsung";
            product2.ProductName = "Galaxy";
            product2.ProductModel = "S5";
            product2.ProductPrice = 3500;
            product2.ProductVaranty = 2;

            Product product3 = new Product();
            product3.ProductCompany = "Xaomi";
            product3.ProductName = "Redmi";
            product3.ProductModel = "Note 8";
            product3.ProductPrice = 2750;
            product3.ProductVaranty = 2;

            Product product4 = new Product();
            product4.ProductCompany = "Vestel";
            product4.ProductName = "Venüs";
            product4.ProductModel = "V100";
            product4.ProductPrice = 3750;
            product4.ProductVaranty = 2;

            Product[] product = new Product[]
            {
                product1,product2,product3,product4
            };
            int sayac = (product.Length -1);
            while (sayac >= 0)
            {
                Console.WriteLine("Firma = " + product[sayac].ProductCompany + "," + "ÜrünAdi = " + product[sayac].ProductName);
                sayac--;

            }

            //for (int i = 0; i < product.Length; i++)
            //{
            //    Console.WriteLine("Firma = " + product[i].ProductCompany + "," + "ÜrünAdi = " + product[i].ProductName);
            //}

            //foreach (Product productt in product)
            //{
            //    Console.WriteLine("Firma = " + productt.ProductCompany + "," + "ÜrünAdi = " + productt.ProductName);

            //}






        }
    }
}
