namespace Tasks.Task2
{
    internal class PersonRunner
    {
        public static void Run()
        {
            List<Person> people = new()
            {
                new Student("Ali", 22, "S1001", "Software Engineering"),
                new Student("Sara", 21, "S1002", "Computer Science"),
                new Professor("Dr. Smith", 45, "P2001", "Object-Oriented Programming"),
                new Professor("Dr. Johnson", 52, "P2002", "Database Systems")
            };

            people.ForEach(person =>
            {
                person.GetDetails();
            });
        }
    }
}
