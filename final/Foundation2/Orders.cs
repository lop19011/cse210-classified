using System;

namespace Foundation2
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        //Constructor
        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        //Encapsulation - Getters

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        private double GetShippingCost()
            {
                if (_customer.LivesInUSA())
                {
                    return 5.0;
                }
                else
                {
                    return 35.0;
                }

            }

        //Abstraction:

        public double CalculateTotalCost()
            {
                double total = 0;

                foreach (Product product in _products)
                {
                    total += product.GetTotalCost();
                }

                total += GetShippingCost();

                return total;
            }

        public string GetPackingLabel()
            {
                string label = "PACKING LABEL:\n";
                label += "=====================\n";

                foreach (Product product in _products)
                {
                    label += $"PRoduct Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
                }

                return label;
            }
        
        public string GetShippingLabel()
            {
                string label = "SHIPPING LABEL:\n";
                label += "=====================\n";

                label += $"{_customer.GetName()}\n";
                label += _customer.GetAddress().GetFullAddress();

                return label;
                
            }

    }

    
}