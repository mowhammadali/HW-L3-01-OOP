namespace Tasks.Task4
{
    internal class Patient : Person
    {
        public string PatientId { get; private set; }
        public List<string> MedicalHistory { get; private set; }

        public Patient(string name, int age, string id, string patientId) : base(name, age, id)
        {
            PatientId = patientId;
            MedicalHistory = new List<string>();
        }

        public Patient(string name, int age, string id, string patientId, List<string> medicalHistory) : this(name, age, id, patientId)
        {
            MedicalHistory = medicalHistory;
        }

        public void AddToMedicalHistory(string illness)
        {
            MedicalHistory.Add(illness);
        }
    }
}
