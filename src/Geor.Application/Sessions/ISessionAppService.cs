using System.Threading.Tasks;
using Abp.Application.Services;
using Geor.Sessions.Dto;

namespace Geor.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
