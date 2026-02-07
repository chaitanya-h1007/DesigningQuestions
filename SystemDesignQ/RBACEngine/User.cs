namespace RBACEngine
{
    public class User
    {
        public int UserId{get; set;}
        public string? RoleType{get; set;}

        public string? PermissionAssigned{get; set;}

        public User(int userId, string roleType)
        {
            this.UserId = userId;
            this.RoleType = roleType;
            this.PermissionAssigned = null;  
        }

    }
    
}