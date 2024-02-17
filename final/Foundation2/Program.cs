using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Milk", "001", 1.00, 6);
        Product product2 = new Product("Ham", "002", 2.00, 2);
        Product product3 = new Product("Rice", "003", 1.50, 4);
        Product product4 = new Product("Water", "004", 0.50, 6);
        Product product5 = new Product("Soda", "005", 2.50, 12);
        Product product6 = new Product("Cheese", "006", 3.50, 1);


        List<Product> _products1 = new List<Product>();
        _products1.Add(product1);
        _products1.Add(product2);
        _products1.Add(product4);
        Address address1 = new Address("Paseo del Generalife 110", "Almeria", "Almeria", "Spain");
        Customer customer1 = new Customer("David Peña", address1);
        Order order1 = new Order(_products1, customer1);

        string _pakingLabel1 = order1.GetPackingLabel();
        Console.WriteLine($"The packing label for this order is:\n{_pakingLabel1}");
        string _shippingLabel1 = order1.GetShippingLabel();
        Console.WriteLine($"The shipping address for this order is:\n{_shippingLabel1}");
        double _totalCost1 = order1.CalculateTotalCost();
        Console.WriteLine($"\nThe total cost for this order is: $ {_totalCost1}\n");

        List<Product> _products2 = new List<Product>();
        _products2.Add(product3);
        _products2.Add(product5);
        _products2.Add(product6);
        Address address2 = new Address("12217 Wood Lake Drive", "BURNSVILLE", "MN 55337", "USA");
        Customer customer2 = new Customer("Jorge Cano", address2);
        Order order2 = new Order(_products2, customer2);

        string _pakingLabel2 = order2.GetPackingLabel();
        Console.WriteLine($"The packing label for this order is:\n{_pakingLabel2}");
        string _shippingLabel2 = order2.GetShippingLabel();
        Console.WriteLine($"The shipping address for this order is:\n{_shippingLabel2}");
        double _totalCost2 = order2.CalculateTotalCost();
        Console.WriteLine($"\nThe total cost for this order is: $ {_totalCost2}\n");
    }
}