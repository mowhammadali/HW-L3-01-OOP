namespace Tasks.Task2
{
    internal class Professor : Person
    {
        public string ProfessorId { get; private set; }
        public string Subject { get; private set; }

        public Professor(string name, int age, string professorId, string subject) : base(name, age)
        {
            ProfessorId = professorId;
            Subject = subject;
        }

        public override string GetDetails()
        {
           return ($"Name: {Name}, Age: {Age}, professor ID: {ProfessorId}, Subject: {Subject}");
        }
    }
}
