using System;
using System.Globalization;
using CourseSC9.Entities;
using CourseSC9.Entities.Enums;

namespace CourseSC9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bithDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, bithDate);
                        
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string namep = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());
                Product p = new Product(namep, price);
                OrderItem item = new OrderItem(p, quant, price);
                order.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
