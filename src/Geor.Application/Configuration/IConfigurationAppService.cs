using System.Threading.Tasks;
using Geor.Configuration.Dto;

namespace Geor.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
