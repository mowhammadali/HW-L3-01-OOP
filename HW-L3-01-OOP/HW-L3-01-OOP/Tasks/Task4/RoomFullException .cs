namespace Tasks.Task4
{
    public class RoomFullException : Exception
    {
        public RoomFullException() : base("Room is full.") { }

        public RoomFullException(string message) : base(message) { }
    }
}
