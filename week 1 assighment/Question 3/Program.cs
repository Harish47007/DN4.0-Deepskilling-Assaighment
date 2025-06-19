using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string category, double price)
        {
            ProductId = id;
            Name = name;
            Category = category;
            Price = price;
        }

        
        public void Display()
        {
            Console.WriteLine($"ID: {ProductId}, Name: {Name}, Category: {Category}, Price: ${Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            List<Product> products = new List<Product>()
            {
                new Product(101, "banana leaf", "utensils", 999.99),
                new Product(102, "oculus quest 4", "Electronics", 899.99),
                new Product(103, "asus tuf gaming", "Computers", 1299.50),
                new Product(104, "bata shoe", "Fashion", 149.99),
                new Product(105, "Apple Watch", "Accessories", 399.99)
            };

           
            Console.Write("Enter product name to search: ");
            string searchQuery = Console.ReadLine().Trim().ToLower();

            
            var results = products
                .Where(p => p.Name.ToLower().Contains(searchQuery))
                .ToList();

            
            if (results.Count > 0)
            {
                Console.WriteLine("\n🔍 Search Results:");
                foreach (var product in results)
                {
                    product.Display();
                }
            }
            else
            {
                Console.WriteLine("\n❌ No products found matching your search.");
            }
        }
    }
}
