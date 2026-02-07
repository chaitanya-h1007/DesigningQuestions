namespace RBACEngine
{
    public class Loan //In this Case Loan is my Resource
    {
        public int LoanId{get; set;}
        public int OwnerId{get; set;}
        public int Amount{get; set;}

        public string? Status{get; set;} //Approved/ pending/ declined

        public Loan(int id, int ownerid, int amount, string? status)
        {
            this.LoanId = id;
            this.OwnerId = ownerid;
            this.Amount = amount;
            this.Status = status; 
        }

        



        
    }
}