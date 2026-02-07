namespace ThreadSafeTicketBooking
{
    public class Seat
    {
        public string SeatNo{get; set;}
        public bool IsBooked{get; private set;}

        public void setIsBooked(bool bookingStatus)
        {
            this.IsBooked = bookingStatus;
        }
    }


    
}