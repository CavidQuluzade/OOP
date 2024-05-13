using HomeTaskInvoice;

Invoice invoice = new  Invoice("6788", "A;", "Df");
invoice.Quantity = 7;
invoice.Price = 2;
invoice.Article = "ddd";
invoice.CostCalculate(true);