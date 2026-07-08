namespace Tasks.Task4
{
    interface IHospital
    {
        List<Doctor> Doctors { get; }
        List<Room> Rooms { get; }
        void AdmitPatient(Patient patient);
        void DischargePatient(Patient patient);
    }

    internal class Hospital : IHospital
    {
        public List<Doctor> Doctors { get; private set; }
        public List<Room> Rooms { get; private set; }
        private static Hospital _instance;

        private Hospital(List<Doctor> doctors, List<Room> rooms)
        {
            Doctors = doctors;
            Rooms = rooms;
        }

        public static Hospital GetInstance(List<Doctor> doctors, List<Room> rooms)
        {
            if (_instance == null)
            {
                _instance = new Hospital(doctors, rooms);
            }

            return _instance;
        }

        public void AdmitPatient(Patient patient)
        {
            foreach (var room in Rooms)
            {
                if (room.Patients.Count < room.Capacity)
                {
                    room.AssignPatient(patient);
                    return;
                }
            }

            throw new RoomFullException();
        }

        public void DischargePatient(Patient patient)
        {
            foreach (var room in Rooms)
            {
                if (room.Patients.Remove(patient))
                {
                    return;
                }
            }

            throw new Exception("Patient not found.");
        }
    }
}

