using System;
using System.Collections.Generic;
class Contact
{
    public string Name { set; get; }
    public string Email { set; get; }
    public int Phone { set; get; }

    public Contact(string name, string email, int phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }
}
class Program
{
    static Dictionary<int, Contact> cBook = new Dictionary<int, Contact>();
    public static void AddContact(string name, string email, int phone)
    {
        if (cBook.ContainsKey(phone))
        {
            Console.WriteLine("Phone number already exists!\n");
            return;
        }
        Contact c1 = new Contact(name, email, phone);
        cBook.Add(phone, c1);
        Console.WriteLine("Contact Added Successfully!\n");
    }
    public static void SearchContact(int phone)
    {
        if (cBook.ContainsKey(phone))
        {
            Contact contact = cBook[phone];
            Console.WriteLine("Name: " + contact.Name + "\nEmail: " + contact.Email + "\nPhone: " + contact.Phone);
        }
        else
            Console.WriteLine("Contact Not Found!\n");
    }
    public static void UpdateContact(int phone)
    {
        if (cBook.ContainsKey(phone))
        {
            Console.WriteLine("Enter New Name:");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter New Email:");
            string newEmail = Console.ReadLine();
            cBook[phone] = new Contact(newName, newEmail, phone);
            Console.WriteLine("Contact Updated Successfully!\n");
        }
        else
            Console.WriteLine("Contact Not Found!\n");
    }
    public static void DeleteContact(int phone)
    {
        if (cBook.ContainsKey(phone))
        {
            cBook.Remove(phone);
            Console.WriteLine("Contact Deleted Successfully!\n");
        }
        else
            Console.WriteLine("Contact Not Found!\n");
    }
    public static void ViewContact()
    {
        foreach (var item in cBook)
        {
            Console.WriteLine("Name: " + item.Value.Name + "\nEmail: " + item.Value.Email + "\nPhone: " + item.Value.Phone + "\n");

        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("\n==========================\n Contact Directory System\n==========================");
        Console.WriteLine("[1] Add a new contact\n[2] Search by phone number\n[3] Update contact details\n[4] Delete a contact\n[5] View all contacts\n[6] Exit\n---------------------\n\nSelect an option (1-6)");
        int choice = int.Parse(Console.ReadLine());
        while (choice != 6)
        {
            if (choice == 1)
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Phone:");
                int phone = int.Parse(Console.ReadLine());

                AddContact(name, email, phone);
            }
            else if (choice == 2)
            {
                if (cBook.Count == 0)
                {
                    Console.WriteLine("Empty Contact\n");
                }
                else
                {
                    Console.WriteLine("Enter Phone:");
                    int phone = int.Parse(Console.ReadLine());
                    SearchContact(phone);
                }
            }
            else if (choice == 3)
            {
                if (cBook.Count == 0)
                {
                    Console.WriteLine("Empty Contact\n");
                }
                else
                {
                    Console.WriteLine("Enter Phone:");
                    int phone = int.Parse(Console.ReadLine());
                    UpdateContact(phone);
                }
            }
            else if (choice == 4)
            {
                if (cBook.Count == 0)
                {
                    Console.WriteLine("Empty Contact\n");
                }
                else
                {
                    Console.WriteLine("Enter Phone:");
                    int phone = int.Parse(Console.ReadLine());
                    DeleteContact(phone);
                }
            }
            else if (choice == 5)
            {
                if (cBook.Count == 0)
                {
                    Console.WriteLine("Empty Contact\n");
                }
                else
                {
                    ViewContact();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");

            }
            Console.WriteLine("[1] Add a new contact\n[2] Search by phone number\n[3] Edit contact details\n[4] Delete a contact\n[5] View all contacts\n[6] Exit\n---------------------\nSelect an option (1-6)\n");
            choice = int.Parse(Console.ReadLine());
        }
    }
}