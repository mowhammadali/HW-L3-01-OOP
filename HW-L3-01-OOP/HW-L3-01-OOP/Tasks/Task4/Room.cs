namespace Tasks.Task4
{
    interface IRoom
    {
        int RoomNumber { get; }
        int Capacity { get; }
        List<Patient> Patients { get; }
        void AssignPatient(Patient patient);
    }

    internal class Room : IRoom
    {
        public int RoomNumber { get; private set; }
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            private set
            {
                if (value < 1)
                {
                    throw new Exception("The Capacity must be greater than zero");
                }
                else
                {
                    _capacity = value;
                }
            }
        }
        public List<Patient> Patients { get; private set; }

        public Room(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Patients = new List<Patient>();
        }

        public Room(int roomNumber, int capacity, List<Patient> patients) : this(roomNumber, capacity)
        {
            if (patients.Count <= Capacity)
            {
                Patients = patients;
                return;
            }

            throw new Exception("This room have no capacity");
        }

        public void AssignPatient(Patient patient)
        {
            if (Patients.Count >= Capacity)
            {
                throw new Exception("This room have no capacity");
            }

            Patients.Add(patient);
        }
    }
}
