using ModelService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataService.Interfaces
{
    public interface IAuthService
    {
        Task<TokenResponseModel> Auth(TokenRequestModel model);
        Task<bool> LogoutUserAsync();
        void DeleteAllCookies(IEnumerable<string> cookiesToDelete);
        void DeleteCookie(string name);
    }
}
