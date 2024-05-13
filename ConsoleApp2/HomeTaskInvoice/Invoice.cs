

using System.Security.Cryptography.X509Certificates;

namespace HomeTaskInvoice
{
    internal class Invoice
    {
        private string Account { get; set; }
        private string Customer { get; set; }
        private string Provider { get; set; }
        public string Article { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }
            public void CostCalculate(bool edv)
            {
                if (edv)
                {
                Price = Price * Quantity;
                Price += Price * 0.18;
                    Console.WriteLine(Price);
                }
                else
                {
                    Price = Price * Quantity;
                    Console.WriteLine(Price);
                }
            }
        

    }
    
}
