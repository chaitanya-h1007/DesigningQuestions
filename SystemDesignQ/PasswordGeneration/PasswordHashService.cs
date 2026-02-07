using System.Security.Cryptography;

namespace PasswordGeneration
{
    public class PasswordHashService
    {
        public string HashPassword(string password)
        {
            string hashCode = "";
            string salt = "@7689";
            password += salt;

            hashCode = password.GetHashCode().ToString();
            return hashCode;
        }


        public bool VerifyPassword(string password, string storedHash)
        {
            string hashofPassword = HashPassword(password);
            if(hashofPassword == storedHash)
                return true;
            
            return false;
        }
    }
}