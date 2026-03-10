using System;

namespace TamerInventoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Initialization - Arrays for 50 products
            string[] productNames = new string[50];
            int[] productQuantities = new int[50];
            int productCount = 0; // Tracks the current number of products

            bool running = true; // Control variable for the main loop

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Tamer Inventory Management System ===");
                Console.WriteLine("1. Show All Products");
                Console.WriteLine("2. Add New Product");
                Console.WriteLine("3. Exit Program");
                Console.Write("\nSelect an option: ");

                string choice = Console.ReadLine();

                // Logic to handle user choice
                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("=== Current Inventory ===");

                    if (productCount == 0)
                    {
                        Console.WriteLine("The inventory is currently empty.");
                    }
                    else
                    {
                        for (int i = 0; i < productCount; i++)
                        {
                            Console.WriteLine($"{i + 1}. Name: {productNames[i]} | Quantity: {productQuantities[i]}");
                        }
                    }
                    Console.WriteLine("\nPress Enter to return to Menu...");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    if (productCount < 50)
                    {
                        Console.WriteLine("=== Add New Product ===");
                        Console.Write("Enter product name: ");
                        productNames[productCount] = Console.ReadLine();

                        Console.Write("Enter quantity: ");
                        // Simple conversion from string to integer
                        productQuantities[productCount] = int.Parse(Console.ReadLine());

                        productCount++; // Increment counter after adding
                        Console.WriteLine("\nProduct added! Press Enter to continue...");
                    }
                    else
                    {
                        Console.WriteLine("Error: Inventory is full (Max 50 products)!");
                    }
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    // Stops the while loop and closes the program
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
        }
    }
}