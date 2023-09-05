using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorySystem
{
    class Product
    { 
        public int ProductId { get; set; }  

        public string Name { get; set; }    

        public int Price { get; set; }
    
    }
    public class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int, Product> productInventory = new Dictionary<int, Product>();

            productInventory.Add(101, new Product { ProductId = 101, Name = "Laptop", Price = 5000 });
            productInventory.Add(102, new Product { ProductId = 101, Name = "JBL Speaker", Price = 8000 });
            productInventory.Add(103, new Product { ProductId = 101, Name = "Portable Charger", Price = 2300 });
            productInventory.Add(104, new Product { ProductId = 101, Name = "iPhone 14", Price = 4600 });
            productInventory.Add(105, new Product { ProductId = 101, Name = "Airpods Pro", Price = 7800 });
            productInventory.Add(106, new Product { ProductId = 101, Name = "Watch", Price = 5500 });
            productInventory.Add(107, new Product { ProductId = 101, Name = "Tablet", Price = 3400 });
            productInventory.Add(108, new Product { ProductId = 101, Name = "TV", Price = 6802 });
            productInventory.Add(109, new Product { ProductId = 101, Name = "Mouse", Price = 3400 });
            productInventory.Add(110, new Product { ProductId = 101, Name = "Keyboard", Price = 2300 });


            Console.WriteLine("Choose between \n 1)Change Price \n 2) Remove product");
            string choice = Console.ReadLine();


            if (choice.Equals("1"))
            {


                Console.WriteLine("Enter the ProductID of the price you want to change: ");
                int IdChoice = int.Parse(Console.ReadLine());

                if (productInventory.ContainsKey(IdChoice))
                {
                    //Product product = productInventory[IdChoice];


                    Console.WriteLine("Enter the new price: ");
                    int newPrice = int.Parse(Console.ReadLine());


                    productInventory[IdChoice].Price = newPrice;
                    Console.WriteLine("Price Updated !");
                    Console.WriteLine(productInventory[IdChoice].Price);




                }
                else
                {
                    Console.WriteLine("Product was not found");
                }

            }

            else if (choice.Equals("2"))
            {


            }



        }
    }
}
