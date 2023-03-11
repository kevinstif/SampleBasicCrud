using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Geor.Controllers
{
    public abstract class GeorControllerBase: AbpController
    {
        protected GeorControllerBase()
        {
            LocalizationSourceName = GeorConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
