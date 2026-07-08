namespace Tasks.Task3
{
    internal class Clothing : Product
    {
        public string Size { get; private set; }
        public string Material { get; private set; }

        public Clothing(string name, double price, string size, string material) : base(name, price)
        {
            Size = size;
            Material = material;
        }

        public override void GetProductDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Size: {Size}, Material: {Material}");
        }
    }
}
