namespace Tasks.Task4
{
    internal class Cardiologist : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient)
        {
            patient.AddToMedicalHistory("Mitral Valve");
        }
    }

    internal class Neurologist : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient)
        {
            patient.AddToMedicalHistory("Migraine");
        }
    }

    internal class ENTSpecialist : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient)
        {
            patient.AddToMedicalHistory("Sinusitis");
        }
    }

    internal class Psychiatrist : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient)
        {
            patient.AddToMedicalHistory("Depression");
        }
    }

    internal class Orthopedist : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient)
        {
            patient.AddToMedicalHistory("Osteoarthritis");
        }
    }
}
