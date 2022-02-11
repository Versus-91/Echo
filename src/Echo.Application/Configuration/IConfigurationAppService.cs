using System.Threading.Tasks;
using Echo.Configuration.Dto;

namespace Echo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
