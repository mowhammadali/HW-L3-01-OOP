namespace Tasks.Task4
{
    internal class Doctor : Person
    {
        public string DoctorId { get; private set; }
        public string Specialization { get; private set; }

        public Doctor(string name, int age, string id, string doctorId, string specialization) : base(name, age, id)
        {
            DoctorId = doctorId;
            Specialization = specialization;
        }

        public void Diagnose(Patient patient)
        {
            patient.AddToMedicalHistory("");
        }
    }
}
