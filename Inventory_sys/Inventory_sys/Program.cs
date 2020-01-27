using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Inventory_sys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ItemList = new List<Product>();
            ItemList.Add(new Product { Name = "lettuce", Price = 10.5, Quantity = 50, type = "Leafy green" });
            ItemList.Add(new Product { Name = "cabbage", Price=20 , Quantity=100, type="Cruciferous"});
            ItemList.Add(new Product { Name = "pumpkin", Price = 30, Quantity = 30, type = "Marrow" });
            ItemList.Add(new Product { Name = "cauliflower", Price = 10, Quantity = 20, type = "Cruciferous" });
            ItemList.Add(new Product { Name = "zucchini", Price = 20.5, Quantity = 50, type = "Marrow" });
            ItemList.Add(new Product { Name = "yam", Price = 30, Quantity = 50, type = "Root" });
            ItemList.Add(new Product { Name = "spinach", Price = 10, Quantity = 100, type = "Leafy green" });
            ItemList.Add(new Product { Name = "broccoli", Price =20.2, Quantity = 75, type = "Cruciferous" });
            ItemList.Add(new Product { Name = "garlic", Price = 30, Quantity = 20, type = "Leafy green" });
            ItemList.Add(new Product { Name = "silverbeet", Price = 10, Quantity = 50, type = "Marrow" });
            Console.WriteLine("Total items in list = " + ItemList.Count);
            ItemList.Add(new Product { Name = "potato", Price = 10, Quantity = 50, type = "Root" });
            foreach (var item in ItemList)
            {
                Console.WriteLine($"Name=: {item.Name}    Price: {item.Price}      Quantity: {item.Quantity}       type: {item.type} ");
            }
            Console.WriteLine();//empty space
            Console.WriteLine("Total items in list = " + ItemList.Count);

            Console.WriteLine();
            Console.WriteLine("Products with type Leafy green:");
            foreach (var ty in ItemList)
            {
                if(ty.type.Equals("Leafy green"))
                {
                    Console.WriteLine($"{ty.Name}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Updated list");
            Console.WriteLine();
            ItemList.RemoveAt(8);
            foreach (var item in ItemList)
            {
                Console.WriteLine($"Name=: {item.Name}    Price: {item.Price}      Quantity: {item.Quantity}       type: {item.type} ");
            }
            Console.WriteLine();
            Console.WriteLine("Total items in list = " + ItemList.Count);
            Console.WriteLine();
            ItemList[1].Quantity += 50;
            Console.WriteLine("Name:"+ItemList[1].Name +"  "+ "Quantity: "+ItemList[1].Quantity);
            double sum = (1 * ItemList[0].Price) + (2 * ItemList[4].Price) + (1 * ItemList[7].Price);
            Console.WriteLine("Total price for 1kg lettuce, 2 kg zucchini, 1 kg broccoli is "+Math.Round(sum)+" RS");

        }
    }
}
