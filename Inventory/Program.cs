using System;
using System.Collections.Generic;
class Item
{
    public string Name { set; get; }
    public double Price { set; get; }
    public Item(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }
}
class program
{
    static List<Item> Inventory = new List<Item>();
    public static void AddItem(string Name, double Price)
    {
        Item item = new Item(Name, Price);
        Inventory.Add(item);
        Console.WriteLine("Item Added Successfully");
    }

    public static void RemoveItem(string Name)
    {
        bool found = false;
        for (int i = 0; i < Inventory.Count; i++)
        {
            if (Name.Equals(Inventory[i].Name))
            {
                Inventory.RemoveAt(i);
                Console.WriteLine("Item Removed Successfully");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Item Not Found");
        }
    }

    public static void DisplayItems()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("Empty Inventory");
        }
        else
        {
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine(Inventory[i].Name + "  " + Inventory[i].Price);
            }
        }
    }

    public static void SerachItem(string Name)
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("Empty Inventory");
        }
        else
        {
            bool found = false;
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (Name.Equals(Inventory[i].Name))
                {
                    Console.WriteLine("Item found! " + Inventory[i].Name + " " + Inventory[i].Price + " JD");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Item not found");
            }
        }
    }

    public static void TotalValues()
    {
        double total = 0;
        for (int i = 0; i < Inventory.Count; i++)
        {
            total += Inventory[i].Price;
        }
        Console.WriteLine("Total Price: " + total);
    }
    public static void SortPrice()
    {
        for (int i = 0; i < Inventory.Count; i++)
        {
            Item key = Inventory[i];
            int j = i - 1;
            while (j >= 0 && Inventory[j].Price > key.Price)
            {
                Inventory[j + 1] = Inventory[j];
                j--;
            }
            Inventory[j + 1] = key;
        }
        DisplayItems();
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("\n=========================\n        Inventory\n=========================");
            Console.WriteLine("1.Add Item" + "\n2.Remove Item" + "\n3.Display Inventory" + "\n4.Search Item" + "\n5.Show Total Value" + "\n6.Sort By Price" + "\n7.Exit");

            Console.Write("\nWhat do you need? ");
            int choice = int.Parse(Console.ReadLine());

            while (choice != 7)
            {
                if (choice == 1)
                {
                    Console.WriteLine("Enter name & price: ");
                    string name = Console.ReadLine();
                    double price = double.Parse(Console.ReadLine());
                    AddItem(name, price);
                }
                else if (choice == 2)
                {
                    if (Inventory.Count == 0)
                    {
                        Console.WriteLine("Empty Inventory");
                    }
                    else
                    {
                        Console.WriteLine("Enter name: ");
                        string name = Console.ReadLine();
                        RemoveItem(name);
                    }
                }
                else if (choice == 3)
                {
                    DisplayItems();
                }
                else if (choice == 4)
                {
                    if (Inventory.Count == 0)
                    {
                        Console.WriteLine("Empty Inventory");
                    }
                    else
                    {
                        Console.WriteLine("Enter name: ");
                        string name = Console.ReadLine();
                        SerachItem(name);
                    }
                }
                else if (choice == 5)
                {
                    if (Inventory.Count == 0)
                    {
                        Console.WriteLine("Empty Inventory");
                    }
                    else
                    {
                        TotalValues();
                    }
                }
                else if (choice == 6)
                {
                    if (Inventory.Count == 0)
                    {
                        Console.WriteLine("Empty Inventory");
                    }
                    else
                    {
                        SortPrice();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }

                Console.WriteLine("\n1.Add Item" + "\n2.Remove Item" + "\n3.Display Inventory" + "\n4.Search Item" + "\n5.Show Total Value" + "\n6.Sort By Price" + "\n7.Exit");
                Console.Write("\nWhat do you need? ");
                choice = int.Parse(Console.ReadLine());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}