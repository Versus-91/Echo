using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Echo.Controllers
{
    public abstract class EchoControllerBase: AbpController
    {
        protected EchoControllerBase()
        {
            LocalizationSourceName = EchoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
