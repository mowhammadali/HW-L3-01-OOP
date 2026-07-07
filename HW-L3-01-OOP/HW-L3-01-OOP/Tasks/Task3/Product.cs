namespace Tasks.Task3
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public void GetProductDetails() {
            Console.WriteLine($"Name: {Name}, Price: {Price}");
        }
    }
}
