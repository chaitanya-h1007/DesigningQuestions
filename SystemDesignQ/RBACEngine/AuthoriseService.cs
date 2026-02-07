namespace RBACEngine
{
    public class AuthoriseService
    {
        public int MANAGER_APPROVAL_LIMIT = 50000;

        public bool Authorize(User user, Permissions permission, Loan loan)
        {
            // Admin can do everything
            if (user.RoleType == "Admin")
            {
                return true;
            }

            // Agent rules
            if (user.RoleType == "Agent")
            {
                if (permission.PermissionType == "ViewSelf")
                {
                    return loan.OwnerId == user.UserId;
                }

                if (permission.PermissionType == "CreateLoan")
                {
                    return true;
                }

                // Agent cannot approve, reject, or view others
                return false;
            }

            // Manager rules
            if (user.RoleType == "Manager")
            {
                if (permission.PermissionType == "ApproveLoan")
                {
                    if(loan.Amount <= MANAGER_APPROVAL_LIMIT)
                    {
                        loan.Status = "Approved";
                        return true;
                    }
                }

                if (permission.PermissionType == "RejectLoan")
                {
                    return true;
                }

                if (permission.PermissionType == "ViewAll")
                {
                    return true;
                }

                if (permission.PermissionType == "CreateLoan")
                {
                    return true;
                }

                return false;
            }

            // Unknown role
            return false;
        }
    }
}