using Abp.Authorization;
using Echo.Authorization.Roles;
using Echo.Authorization.Users;

namespace Echo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
