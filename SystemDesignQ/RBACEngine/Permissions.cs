namespace RBACEngine
{
    public class Permissions
    {
        public int PersmissionID{get; set;}
        public string PermissionType{get; set;}


        public Permissions(int id, string type)
        {
            this.PersmissionID = id;
            this.PermissionType = type;
            
        }
    }
}