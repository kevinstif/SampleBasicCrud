using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Geor.EntityFrameworkCore;
using Geor.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Geor.Web.Tests
{
    [DependsOn(
        typeof(GeorWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GeorWebTestModule : AbpModule
    {
        public GeorWebTestModule(GeorEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GeorWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GeorWebMvcModule).Assembly);
        }
    }
}