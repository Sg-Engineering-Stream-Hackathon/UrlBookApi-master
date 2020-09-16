using System.Threading.Tasks;

namespace FunctionalService
{
    public interface IFunctionalService
    {
        Task CreateDefaultUser(string role);
    }
}
