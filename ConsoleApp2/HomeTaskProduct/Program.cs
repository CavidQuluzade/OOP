namespace HomeTaskProduct;
public class Program
{
 public static void Main()
    {
        Electronic electronic1 = new Electronic("aaa", 200, "bbb");
        Clothes clothes = new("aa",12,"M");
        Order order1 = new Order();
        order1.AddProduct(clothes);
        order1.AddProduct(electronic1);
        order1.GetProductDetail();
        order1.GetTotalAmount();
    }
}


