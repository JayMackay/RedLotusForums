using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LotusForums.Data;
using LotusForums.Data.Models;

namespace LotusForums.Service
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAllActiveUSers()
        {
            throw new NotImplementedException();
        }

        public IForum GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
