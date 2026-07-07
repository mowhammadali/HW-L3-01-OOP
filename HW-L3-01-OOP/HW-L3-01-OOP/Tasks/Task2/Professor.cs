namespace Tasks.Task2
{
    internal class Professor : Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string ProfessorId { get; private set; }
        public string Subject { get; private set; }

        public Professor(string name, int age, string professorId, string subject) : base(name, age)
        {
            Name = name;
            Age = age;
            ProfessorId = professorId;
            Subject = subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, professor ID: {ProfessorId}, Subject: {Subject}");
        }
    }
}
