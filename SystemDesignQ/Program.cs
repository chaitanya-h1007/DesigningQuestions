
using System.Diagnostics;
using ApiRateLimiter;
using PasswordGeneration;

namespace ThreadSafeTicketBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the password");
            string inputPass = Console.ReadLine();
            PasswordData pd = new PasswordData();
            PasswordHashService ph = new PasswordHashService();
             
             pd.setPasswordHash(ph.HashPassword(inputPass));
            System.Console.WriteLine(ph.VerifyPassword(inputPass,pd.PasswordHash));
            System.Console.WriteLine(pd.PasswordHash);
            System.Console.WriteLine(pd.GetHashCode());
        }
    }
}

