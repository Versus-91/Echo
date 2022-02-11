using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Echo.Authorization;

namespace Echo
{
    [DependsOn(
        typeof(EchoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EchoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EchoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EchoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
