using Abp.Authorization;
using MyCompany.MyProjectDemo.Authorization.Roles;
using MyCompany.MyProjectDemo.Authorization.Users;

namespace MyCompany.MyProjectDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
