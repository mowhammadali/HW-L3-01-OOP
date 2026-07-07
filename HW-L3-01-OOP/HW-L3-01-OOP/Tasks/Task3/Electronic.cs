namespace Tasks.Task3
{
    internal class Electronic : Product, IDiscountable
    {
        public int WarrantyPeriod { get; private set; }

        public Electronic(string name, double price, int period) : base(name, price)
        {
            WarrantyPeriod = period;
        }

        public void ApplyDiscount(double percent)
        {
            Price = Price - (Price * (percent / 100));
        }

        public override void GetProductDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Period: {WarrantyPeriod}");
        }
    }
}
