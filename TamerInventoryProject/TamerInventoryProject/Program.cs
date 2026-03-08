using System;

namespace TamerInventoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialization
            string[] productNames = new string[50];
            int[] productQuantities = new int[50];
            int productCount = 0;
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Tamer Inventory Management System ===");
                Console.WriteLine("1. Show All Products");
                Console.WriteLine("2. Add New Product");
                Console.WriteLine("3. Exit");
                Console.WriteLine("4. Search for a Product");
                Console.Write("\nSelect an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // Show All Products
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
                        break;

                    case "2": // Add New Product
                        Console.Clear();
                        if (productCount < 50)
                        {
                            Console.WriteLine("=== Add New Product ===");
                            Console.Write("Enter product name: ");
                            productNames[productCount] = Console.ReadLine();

                            // Secure quantity input
                            bool validQty = false;
                            while (!validQty)
                            {
                                Console.Write("Enter quantity: ");
                                string qtyInput = Console.ReadLine();
                                if (int.TryParse(qtyInput, out productQuantities[productCount]))
                                {
                                    validQty = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input! Please enter a number for quantity.");
                                }
                            }

                            productCount++;
                            Console.WriteLine("\nProduct added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Error: Inventory is full!");
                        }
                        break;

                    case "3": // Exit
                        Console.WriteLine("Exiting the program... Goodbye!");
                        running = false;
                        break;

                    case "4": // Search
                        Console.Clear();
                        Console.WriteLine("=== Product Search ===");
                        if (productCount == 0)
                        {
                            Console.WriteLine("Nothing to search. Inventory is empty.");
                        }
                        else
                        {
                            Console.Write("Please insert the Product Name: ");
                            string searchTerm = Console.ReadLine();
                            bool found = false;

                            for (int i = 0; i < productCount; i++)
                            {
                                if (productNames[i].ToLower() == searchTerm.ToLower())
                                {
                                    Console.WriteLine($"\nResult: Found Product: {productNames[i]} | Quantity: {productQuantities[i]}");
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine("\nProduct not found.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                // Pause the screen before clearing for the next loop
                if (running)
                {
                    Console.WriteLine("\nPress Enter to return to Menu...");
                    Console.ReadLine();
                }
            }
        }
    }
}