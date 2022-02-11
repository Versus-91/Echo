using System.Threading.Tasks;
using Abp.Application.Services;
using Echo.Sessions.Dto;

namespace Echo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
