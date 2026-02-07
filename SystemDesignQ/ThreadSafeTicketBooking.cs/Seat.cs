namespace ThreadSafeTicketBooking
{
    public class Seat
    {
        public string? SeatNo{get; set;}
        public bool IsBooked{get; private set;}

        public Seat(string seatNo)
        {
            this.SeatNo = seatNo;
            this.IsBooked = false;
            
        }

        public void setIsBooked(bool bookingStatus)
        {
            this.IsBooked = bookingStatus;
        }
    }


    
}