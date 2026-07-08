namespace Tasks.Task3
{
    internal class ProductRunner
    {
        public static void Run() {
            Electronic laptop = new Electronic("MacBook Air M3", 1299.99, 24);
            Clothing tShirt = new Clothing("Basic T-Shirt", 29.99, "L", "Cotton");

            laptop.ApplyDiscount(10);

            laptop.GetProductDetails();
            tShirt.GetProductDetails();
        }
    }
}
