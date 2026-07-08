namespace Tasks.Task2
{
    internal class Student : Person
    {
        public string StudentID { get; private set; }
        public string Major { get; private set; }

        public Student(string name, int age, string studentID, string major) : base(name, age)
        {
            StudentID = studentID;
            Major = major;
        }

        public override string GetDetails()
        {
           return ($"Name: {Name}, Age: {Age}, Student ID: {StudentID}, Major: {Major}");
        }
    }
}
