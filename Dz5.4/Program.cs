using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dz5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article toy = new Article("toy", "avrora", 1444);
            Article pen = new Article("pen", "avrora", 1444);
            Article bullet = new Article("bullet", "avrora", 1444);
            Article pochka = new Article("pochka", "avrora", 10000);
            Store store = new Store(toy, pen, bullet, pochka);
            store.PrintArticleInfo("io", 5);
            Console.ReadLine();
        }
    }
    class Article
    {
        private string Name { get; set; }
        private string storeName { get; set; }
        private double price { get; set; }
        public Article(string name, string storeName, double price)
        {
            Name = name;
            this.storeName = storeName;
            this.price = price;
        }
        public string ProductName { get { return Name; } }
        public string StoreName { get { return storeName; } }
        public double Price { get { return price; } }
    }
    class Store
    {
        private Article[] Arta;
        public Store(params Article[] art)
        {
            Arta = art;
        }
        public void PrintArticleInfo(string productName, int index)
        {
            bool found = false;
            int ndex = 0;
            foreach (Article article in Arta)
            {
                if (article.ProductName == productName)
                {
                    Console.WriteLine("Назва товару: {0}", article.ProductName);
                    Console.WriteLine("Назва магазину: {0}", article.StoreName);
                    Console.WriteLine("Вартість товару: {0} грн", article.Price);
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                Console.WriteLine("Товар з назвою {0} не знайдено", productName);
                foreach (Article article in Arta)
                {
                    if (ndex == index)
                    {
                        Console.WriteLine($"хоч ім'я не правильна,але за індексом це буде товар: {article.ProductName}");
                        Console.WriteLine($"Назва магазину: {article.StoreName}");
                        Console.WriteLine($"Вартість товару: {article.Price} грн");
                        break;
                    }
                    ndex++;
                }
            }
        }
    }
}
