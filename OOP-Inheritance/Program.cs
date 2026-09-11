using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // is a ilişkisi 
            // has a ilişkisi
            // uses a ilişkisi 


            GidaCategory cat1 = new GidaCategory("Gıda", 0.2);
            GiyimCategory cat2 = new GiyimCategory("Giyim", 0.08);
            CleanCategory cat3 = new CleanCategory("Temizlik", 0.18);

            cat1.info();
            cat2.info();
            cat3.info();

            Product p1 = new Product("Eti", cat1, 50, "Karam");
            Product p2 = new Product("Eti", cat1, 55, "Negro");
            Product p3 = new Product("Ülker", cat1, 60, "Biskrem");
            Product p4 = new Product("Bifa", cat1, 50, "Püskevit");
            Product p5 = new Product("LCW", cat2, 500, "Atlet");
            Product p6 = new Product("Bingo", cat3, 500, "Bingo Jel");
            Product p7 = new Product("Seher Yıldızı", cat2, 500, "Kilot");
            Product p8 = new Product("Unilever", cat3, 950, "Rinso MAtik");
            Product p9 = new Product("Kiğılı", cat2, 5000, "Takım Elbise");

            Console.WriteLine($"Ürün Adı: {p1.Name}, KDV'li Fiyatı: {p1.GetPrice()}, KDV'siz Fiyat: {p1.Price}");
            Console.WriteLine($"Ürün Adı: {p2.Name}, Fiyatı: {p2.GetPrice()}, KDV'siz Fiyat: {p2.Price}");
            Console.WriteLine($"Ürün Adı: {p3.Name}, Fiyatı: {p3.GetPrice()}");
            Console.WriteLine($"Ürün Adı: {p4.Name}, Fiyatı: {p4.GetPrice()}");
            Console.WriteLine($"Ürün Adı: {p5.Name}, Fiyatı: {p5.GetPrice()}");
            Console.WriteLine($"Ürün Adı: {p6.Name}, Fiyatı: {p6.GetPrice()}");
            Console.WriteLine($"Ürün Adı: {p7.Name}, Fiyatı: {p7.GetPrice()}");
            Console.WriteLine($"Ürün Adı: {p8.Name}, Fiyatı: {p8.GetPrice()}");
            Console.WriteLine($"Ürün Adı: {p9.Name}, Fiyatı: {p9.GetPrice()}");
           
        }
    }
}
