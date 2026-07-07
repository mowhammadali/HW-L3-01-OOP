namespace Tasks.Task2
{
    internal class Student : Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string StudentID { get; private set; }
        public string Major { get; private set; }

        public Student(string name, int age, string studentID, string major) : base(name, age)
        {
            Name = name;
            Age = age;
            StudentID = studentID;
            Major = major;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentID}, Major: {Major}");
        }
    }
}
