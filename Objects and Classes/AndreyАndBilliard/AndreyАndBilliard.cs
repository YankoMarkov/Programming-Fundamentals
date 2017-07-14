using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Customer
{
    public string Name { get; set; }
    public Dictionary<string, int> ShopList { get; set; }
    public decimal Bill { get; set; }
}

class AndreyАndBilliard
{
    static void Main(string[] args)
    {
        var products = AddProducts();
        var customer = AddCustomer(products);
        decimal totalBill = 0;

        foreach (var item in customer.OrderBy(s => s.Name))
        {
            Console.WriteLine(item.Name);
            foreach (var items in item.ShopList)
            {
                Console.WriteLine($"-- {items.Key} - {items.Value}");
            }
            Console.WriteLine($"Bill: {item.Bill:f2}");
            totalBill += item.Bill;
        }
        Console.WriteLine($"Total bill: {totalBill:f2}");
    }

    private static List<Customer> AddCustomer(Dictionary<string, decimal> products)
    {
        string inputs = null;
        List<Customer> customers = new List<Customer>();

        while ((inputs = Console.ReadLine()) != "end of clients")
        {
            Customer customer = new Customer();
            customer.ShopList = new Dictionary<string, int>();
            var input = inputs.Split('-', ',').ToArray();
            var name = input[0];
            var product = input[1];
            var quantity = int.Parse(input[2]);

            if (!products.Keys.Contains(product))
            {
                continue;
            }
            customer.Name = name;
            customer.ShopList.Add(product, quantity);
            customer.Bill = quantity * products[product];

            if (customers.Any(s => s.Name == name))
            {
                Customer existingCustomer = customers.First(s => s.Name == name);
                if (existingCustomer.ShopList.ContainsKey(product))
                {
                    existingCustomer.ShopList[product] += quantity;
                    existingCustomer.Bill += customer.Bill;
                }
                else
                {
                    existingCustomer.ShopList.Add(product, quantity);
                    existingCustomer.Bill += customer.Bill;
                }
            }
            else
            {
                customers.Add(customer);
            }
        }
        return customers;
    }

    private static Dictionary<string, decimal> AddProducts()
    {
        var num = int.Parse(Console.ReadLine());
        var products = new Dictionary<string, decimal>();

        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split('-').ToArray();
            var name = input[0];
            var price = decimal.Parse(input[1]);

            if (!products.ContainsKey(name))
            {
                products.Add(name, 0);
            }
            products[name] = price;
        }
        return products;
    }
}

