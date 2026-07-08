namespace Tasks.Task4
{
    internal class HospitalRunner
    {
        public static void Run()
        {
            Patient patient1 = new("Ethan Walker", 30, "00706045", "p101");
            Patient patient2 = new("Olivia Carter", 55, "00732009", "p102", new List<string> { "Hypertension", "Diabetes", "Asthma" });
            Patient patient3 = new("Lucas Bennett", 42, "00136701", "p103");
            Patient patient4 = new("Sophia Mitchell", 15, "00136701", "p104", new List<string> { "Asthma" });

            Doctor doctor1 = new Doctor("James Anderson", 45, "1234567890", "d101", "Cardiologist", new Cardiologist());
            Doctor doctor2 = new Doctor("Emma Thompson", 38, "2345678901", "d102", "ENTSpecialist", new ENTSpecialist());
            Doctor doctor3 = new Doctor("Michael Johnson", 50, "3456789012", "d103", "Psychiatrist", new Psychiatrist());
            Doctor doctor4 = new Doctor("Charlotte Wilson", 41, "4567890123", "d104", "Orthopedist", new Orthopedist());
            Doctor doctor5 = new Doctor("William Davis", 36, "5678901234", "d105", "Neurologist", new Neurologist());

            doctor1.Diagnose(patient1);
            doctor1.Diagnose(patient2);

            doctor3.Diagnose(patient3);

            patient2.ShowMedicalHistory();
        }
    }
}
