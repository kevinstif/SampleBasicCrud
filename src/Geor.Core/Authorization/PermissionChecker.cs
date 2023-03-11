using Abp.Authorization;
using Geor.Authorization.Roles;
using Geor.Authorization.Users;

namespace Geor.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
