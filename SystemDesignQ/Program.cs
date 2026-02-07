

using System.Runtime.InteropServices;

namespace RBACEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /// Create All permissions First 
           /// Create Loan, ApproveLoan, RejectLoan, ViewAll, ViewSelf
           Permissions CreateLoan = new Permissions(1,"CreateLoan");
           Permissions ApproveLoan = new Permissions(2, "ApproveLoan");
           Permissions Rejection = new Permissions(3, "RejectLoan");
           Permissions ViewAll = new Permissions(4, "VeiwAll");
           Permissions ViewSelf = new Permissions(5, "ViewSelf");


           ///Create Roles For this
           User Admin = new User(1, "Admin");
           User Manager = new User(2, "Manager");
           User Agent = new User(3, "Agent");


           //Create Some Resources To give access


           Loan loan1 = new Loan(1, 3, 60000, "Pending");
           Loan loan2 = new Loan(2, 3, 40000, "Pending");

           AuthoriseService authoriseService = new AuthoriseService();

            System.Console.WriteLine(authoriseService.Authorize(Agent, ViewSelf, loan1));
             // true
            System.Console.WriteLine(authoriseService.Authorize(Agent, ViewSelf, loan2));
              // true
            System.Console.WriteLine(authoriseService.Authorize(Manager, ApproveLoan, loan1));

            // false
            System.Console.WriteLine(authoriseService.Authorize(Manager, ApproveLoan, loan2));
            
            // true
            System.Console.WriteLine(authoriseService.Authorize(Admin, Rejection, loan1)); 
            //true   

        }
    }
}

