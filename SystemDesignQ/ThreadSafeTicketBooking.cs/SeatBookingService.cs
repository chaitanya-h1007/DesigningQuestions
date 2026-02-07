
using System.Runtime.Versioning;

namespace ThreadSafeTicketBooking
{
    public class SeatBookingService
    {
        private static List<Seat> seats = new SeatUtility().GetSeatList();
        //This is my key to the seatstorage
        private static readonly object _seatLock = new object();

        public bool BookSeat(string seatChoice, string userId)
        {
            //Thread Safe function ;

            //Lock the Seat;
            lock (_seatLock)
            {
                foreach (var item in seats)
                {
                    if (item.SeatNo != seatChoice) throw new Exception("Entered Choice NotFound");
                    if (item.IsBooked) return false;

                    item.setIsBooked(true);
                    return true;
                    
                }

                return false;
                
            }
        }


        public bool SeatPresentOrNot(string choice)
        {
            foreach(var item in seats)
            {
                if(item.SeatNo == choice) return true;

            }

            return false;
        }

        public bool CheckSeatAvailabe(string choice)
        {
            foreach (var item in seats)
            {
                if(item.SeatNo == choice && item.IsBooked == true)
                {
                    return false;
                }  
            }
            return true;
        }



        
    }
}