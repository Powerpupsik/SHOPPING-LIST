using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        public static List<String> list;

        static void Main(string[] args)
        {
            list = GetString();
            string command = "";
            while(command != "1")
            {
                PrintList();
                Console.WriteLine("Enter 1 if  you want to exit.");
                Console.WriteLine("Enter 2 if you want to add something.");
                Console.WriteLine("Enter 3 if you want to remove anything");

                command = Console.ReadLine();
                if (command == "1")
                {
                    break;
                }
                else if (command == "2")
                {
                    NewItem();
                }
                else if(command=="3")
                {
                    RemoveItem();
                }
                else
                {
                    Console.WriteLine("This command doesn't exist.");
                }
            }
            Console.WriteLine("Shop wisley!");
            Console.ReadLine();
        }
        public static List<string> GetString()
        {
            Console.WriteLine("Hello! Insert goods to the cart:");
            string goods = Console.ReadLine();

            List<string> products = goods.Split(", ").ToList();
            return products;
            
        }

        public static void PrintList()
        {
            Console.Clear();
            for(int i=0; i< list.Count; i++)
            {
                Console.WriteLine($"Item {i + 1} {list[i]}");
            }
        }

        public static void NewItem()
        {
            Console.WriteLine("Enter the item you would like to add: ");
            string newItem = Console.ReadLine();
            list.Add(newItem);
        }

        public static void RemoveItem()
        {
            Console.WriteLine($"Enter the item number (1-{list.Count}) you would like to remove: ");
            string removeItem = Console.ReadLine();
            int answer = Int32.Parse(removeItem);
            list.RemoveAt(answer - 1);
        }
    }

}
