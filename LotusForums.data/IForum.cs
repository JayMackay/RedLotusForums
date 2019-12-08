using System.Collections.Generic;
using System.Threading.Tasks;
using LotusForums.Data.Models;

namespace LotusForums.Data
{
    public interface IForum
    {
        IForum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUSers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
    }
}
