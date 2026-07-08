namespace Tasks.Task4
{
    interface IPatient
    {
        string PatientId { get; }
        List<string> MedicalHistory { get; }
        void AddToMedicalHistory(string illness);
        void ShowMedicalHistory();
    }

    internal class Patient : Person, IPatient
    {
        public string PatientId { get; private set; }
        public List<string> MedicalHistory { get; private set; }

        public Patient(string name, int age, string nationalId, string patientId) : base(name, age, nationalId)
        {
            PatientId = patientId;
            MedicalHistory = new List<string>();
        }

        public Patient(string name, int age, string nationalId, string patientId, List<string> medicalHistory) : this(name, age, nationalId, patientId)
        {
            MedicalHistory = medicalHistory;
        }

        public void AddToMedicalHistory(string illness)
        {
            MedicalHistory.Add(illness);
        }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, NationalId: {NationalId}, Patient Id: {PatientId}";
        }

        public void ShowMedicalHistory()
        {
            MedicalHistory.ForEach(m => Console.WriteLine(m));
        }
    }
}
