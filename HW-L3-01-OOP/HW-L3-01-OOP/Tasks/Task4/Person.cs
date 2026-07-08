namespace Tasks.Task4
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string NationalId { get; private set; }

        public Person(string name, int age, string id)
        {
            Name = name;
            Age = age;
            NationalId = id;
        }

        public string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, NationalId: {NationalId}";
        }
    }
}
