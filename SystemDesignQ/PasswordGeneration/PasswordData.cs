namespace PasswordGeneration
{
    public class PasswordData
    {
        public string Password{get; set;}
        public string PasswordHash{get; private set;}
        public string getPassword()
        {
            return Password;
        }

        public void setPasswordHash(string hash)
        {
            this.PasswordHash = hash;
            
        }

    }
}