using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Echo.EntityFrameworkCore;
using Echo.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Echo.Web.Tests
{
    [DependsOn(
        typeof(EchoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EchoWebTestModule : AbpModule
    {
        public EchoWebTestModule(EchoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EchoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EchoWebMvcModule).Assembly);
        }
    }
}