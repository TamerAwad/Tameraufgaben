using System;
using System.Runtime.InteropServices;
namespace TamerInventoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = new string[50];
            int[] productQuantities = new int[50];
            int productCount = 0;
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Tamer Inventory Management System");
                Console.WriteLine("1. Show All Products");
                Console.WriteLine("2. Add New Product");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option:");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nDisplaying all products...");
                        break;
                    case "2":
                        Console.WriteLine("\nAdding a new product...");
                        if (productCount < 50)
                        {
                            Console.WriteLine("Enter prduct name: ");
                            productNames[productCount] = Console.ReadLine();

                            Console.Write("Enter quantity: ");
                            productQuantities[productCount] = Convert.ToInt32(Console.ReadLine());

                            productCount++;
                            Console.WriteLine("Product added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Inventory is full !");
                       
                        
                        }
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
                if (running)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.WriteLine();


                }
            }
        }



    }
}
