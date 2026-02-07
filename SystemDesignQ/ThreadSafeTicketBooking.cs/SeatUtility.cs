namespace ThreadSafeTicketBooking
{
    public class SeatUtility
    {
        private static List<Seat> seatStorage = new List<Seat>();
        public void AddSeats(Seat seat)
        {
            seatStorage.Add(seat);
        }

        public List<Seat> GetSeatList()
        {
            return seatStorage;
        }

    }
}