using ModelService;
using System.Threading.Tasks;

namespace DataService.Interfaces
{
    public interface IBookmarkCardService
    {
        Task<bool> CreateBookMarkCard(BookmarkCard bookmarkCard);
    }
}
