namespace Tasks.Task4
{
    internal class Doctor : Person
    {
        public string DoctorId { get; private set; }
        public string Specialization { get; private set; }
        private IDiagnosisStrategy _diagnosisStrategy;

        public Doctor(string name, int age, string id, string doctorId, string specialization , IDiagnosisStrategy diagnosisStrategy) : base(name, age, id)
        {
            DoctorId = doctorId;
            Specialization = specialization;
            _diagnosisStrategy = diagnosisStrategy;
        }

        // Strategy Pattern
        public void SetStrategy(IDiagnosisStrategy strategy)
        {
            _diagnosisStrategy = strategy;
        }

        public void Diagnose(Patient patient)
        {
            _diagnosisStrategy.Diagnose(patient);
        }
    }
}
