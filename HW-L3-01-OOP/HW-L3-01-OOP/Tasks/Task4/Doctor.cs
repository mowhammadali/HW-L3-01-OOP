namespace Tasks.Task4
{
    interface IDoctor
    {
        string DoctorId { get; }
        string Specialization {  get; }
        void Diagnose(Patient patient);
    }

    internal class Doctor : Person , IDoctor
    {
        public string DoctorId { get; private set; }
        public string Specialization { get; private set; }
        private IDiagnosisStrategy _diagnosisStrategy;

        public Doctor(string name, int age, string nationalId, string doctorId, string specialization , IDiagnosisStrategy diagnosisStrategy) : base(name, age, nationalId)
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
