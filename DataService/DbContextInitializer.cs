using FunctionalService;
using System.Linq;
using System.Threading.Tasks;

namespace DataService
{
    public class DbContextInitializer
    {
        public static async Task Initialize(ApplicationDbContext applicationDbContext, IFunctionalService functionalSvc)
        {
            // Check, if db ApplicationDbContext is created
            await applicationDbContext.Database.EnsureCreatedAsync();

            // Check, if db contains any users. If db is not empty, then db has been already seeded
            if (applicationDbContext.ApplicationUsers.Any())
            {
                return;
            }

            // If empty create Admin User
            await functionalSvc.CreateDefaultUser("Administrator");
            
        }
    }
}
