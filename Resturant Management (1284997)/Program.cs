using Resturant_Management__1284997_.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management__1284997_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var itemFactory = new ItemFactory();
            var itemRepository = new ItemRepository();
            AddCommand();

            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    var command = Console.ReadLine().ToLower();
                    if (command == "co")
                    {
                        AddCommand();
                    }
                    else if (command == "m")
                    {
                        isRunning = false;
                    }
                    else if (command == "ri")
                    {
                        Console.WriteLine("Type an Item No");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var retrievedItem = itemRepository.Read(id) as Item;

                        if (retrievedItem != null)
                        {
                            Console.WriteLine($"Item:{retrievedItem.ItemName},Price:{retrievedItem.Price},Quantity:{retrievedItem.Quantity},Date:{retrievedItem.CreateDate},Supplier_Name:{retrievedItem.Supplier_Name},Email{retrievedItem.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                    }
                    else if (command == "ci")
                    {
                        Console.WriteLine("Type an Item Name");
                        var itemName = Console.ReadLine();
                        Console.WriteLine("Enter Price:");
                        var price = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Quantity:");
                        var quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Date (YYYY-MM-DD):");
                        var date = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Supplier_Name:");
                        var supplier = (Console.ReadLine());
                        Console.WriteLine("Enter E-mail:");
                        var email = (Console.ReadLine());

                        // Create a new item
                        var item = itemFactory.CreateEntity() as Item;
                        if (item != null)
                        {

                            item.ItemName = itemName;
                            item.Price = price;
                            item.Quantity = quantity;
                            item.CreateDate = date;
                            item.Supplier_Name = supplier;
                            item.Email = email;
                            itemRepository.Create(item);
                            Console.WriteLine("Item created successfully.");




                        }
                    }
                    else if (command == "ui")
                    {
                        Console.WriteLine("Type an Item no");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var updatedItem = itemRepository.Read(id) as Item;

                        if (updatedItem != null)
                        {
                            Console.WriteLine($"Current Item Name: {updatedItem.ItemName}");
                            Console.WriteLine("Type a new item name to update:");
                            var newItemName = Console.ReadLine();
                            Console.WriteLine("Enter new Price:");
                            var newPrice = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Enter new Quantity:");
                            var newQuantity = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Date (YYYY-MM-DD):");
                            var newDate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Type a new Supplier name to update:");
                            var supplier = Console.ReadLine();
                            Console.WriteLine("Type a new Email to update:");
                            var email = Console.ReadLine();

                            updatedItem.ItemName = newItemName;
                            updatedItem.Price = newPrice;
                            updatedItem.Quantity = newQuantity;
                            updatedItem.CreateDate = newDate;
                            updatedItem.Supplier_Name = supplier;
                            updatedItem.Email = email;
                            itemRepository.Update(updatedItem);
                            Console.WriteLine("Item updated successfully.");




                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                    }
                    else if (command == "di")
                    {
                        Console.WriteLine("Type an Item no");
                        var itemNo = Convert.ToInt32(Console.ReadLine());
                        var deleteItem = itemRepository.Read(itemNo);

                        if (deleteItem != null)
                        {
                            Console.WriteLine($"Delete item: {deleteItem.ItemName}, Price: {deleteItem.Price}, Quantity:, Date: {deleteItem.CreateDate},Supplier_Name:{deleteItem.Supplier_Name},Email{deleteItem.Email}");
                            itemRepository.Delete(itemNo);
                            Console.WriteLine("Item deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        static void AddCommand()
        {
            Console.WriteLine("Press 'RI' to read an item");
            Console.WriteLine("Press 'CI' to create an item");
            Console.WriteLine("Press 'UI' to update an item");
            Console.WriteLine("Press 'DI' to delete an item");
            Console.WriteLine("Press 'CO' to clear window and 'M' for exit");
        }
    }
}
