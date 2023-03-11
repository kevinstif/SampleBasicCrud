using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Geor.Authorization;

namespace Geor
{
    [DependsOn(
        typeof(GeorCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GeorApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GeorAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GeorApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
