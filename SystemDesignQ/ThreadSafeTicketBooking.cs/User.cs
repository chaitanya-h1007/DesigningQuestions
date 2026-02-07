namespace ThreadSafeTicketBooking
{
    public class User
    {
        public string? UserId{get; set;}
        public string? UserName{get; set;}
        public string? SeatChoice{get; set;}


        public User(string userID, string userName, string seatChoice)
        {

            this.UserId = userID;
            this.UserName = userName;
            this.SeatChoice = seatChoice;
            
        }
    }
}