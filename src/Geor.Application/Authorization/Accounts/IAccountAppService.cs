using System.Threading.Tasks;
using Abp.Application.Services;
using Geor.Authorization.Accounts.Dto;

namespace Geor.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
