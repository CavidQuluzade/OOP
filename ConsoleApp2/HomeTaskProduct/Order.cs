using System.Security.Cryptography.X509Certificates;

namespace HomeTaskProduct
{
    internal class Order
    {
        private Product[] products;
        public Product[] Products 
        {
            get
            { 
                return products; 
            } 
        }
        public int Limits { get; } = 10;

        public Order()
        {
            products = new Product[0];
        }
        public void AddProduct(Product product)
        {
            if (Limits > products.Length) 
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("You have products more than 10");
            }
        }
        public void RemoveProduct(Product product)
        {
            var index = Array.IndexOf(products, product);
            if (index != -1) 
            {
                for (int i = index; i < products.Length-1; i++)
                {
                    products[i] = products[i+1];
                    Array.Resize (ref products, products.Length - 1);
                }
            }
            else
            {
                Console.WriteLine("You don't buy this product");
            }
        }
        public void GetTotalAmount()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price;
                Console.WriteLine(total);
            }
        }
        

        public  void GetProductDetail()
        {
            foreach (var product  in products) 
            {
                Console.WriteLine(product.GetProductDetail());
            }
        }














    }
}
