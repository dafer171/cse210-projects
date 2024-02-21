public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.TotalCost();
        }

        double shippingCost = 0;

        if (CustomerUSA() == true)
        {
            shippingCost = 5;
        }
        else shippingCost = 35;

        return _totalCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductDetails()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string customerName = _customer.GetCustomerName();
        string customerAddress = _customer.GetCustomerAddress();
        return $"{customerName}\n{customerAddress}";
    }
    public bool CustomerUSA()
    {

        return _customer.CustomerUSA();
    }

}