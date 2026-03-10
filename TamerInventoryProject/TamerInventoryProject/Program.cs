using System;

namespace TamerInventoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. التعريفات (المصفوفات والعداد)
            string[] productNames = new string[50];
            int[] productQuantities = new int[50];
            int productCount = 0;

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Tamer Inventory System ===");
                Console.WriteLine("1. Show Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Exit");
                Console.Write("\nSelect: ");

                string choice = Console.ReadLine();

                // هنا الـ IF البسيطة التي تعرفها من الكورس
                if (choice == "1")
                {
                    Console.Clear();
                    if (productCount == 0)
                    {
                        Console.WriteLine("Inventory is empty!");
                    }
                    else
                    {
                        for (int i = 0; i < productCount; i++)
                        {
                            Console.WriteLine($"{i + 1}. {productNames[i]} - Qty: {productQuantities[i]}");
                        }
                    }
                    Console.ReadLine(); // للانتظار
                }
                else if (choice == "2")
                {
                    if (productCount < 50)
                    {
                        Console.Write("Name: ");
                        productNames[productCount] = Console.ReadLine();
                        Console.Write("Qty: ");
                        productQuantities[productCount] = int.Parse(Console.ReadLine());
                        productCount++;
                    }
                }
                else if (choice == "3")
                {
                    running = false;
                }
            }
        }
    }
}