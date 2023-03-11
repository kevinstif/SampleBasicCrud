using Abp.Application.Services;
using Geor.MultiTenancy.Dto;

namespace Geor.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

