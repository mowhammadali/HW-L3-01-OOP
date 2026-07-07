namespace Tasks.Task2
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name , int age) { 
            Name = name;
            Age = age;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
