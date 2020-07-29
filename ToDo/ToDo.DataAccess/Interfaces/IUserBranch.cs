using System.Collections.Generic;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Interfaces
{
    public interface IUserBranch
    {
        void Save(User table);
        void Delete(User table);
        void Update(User table);
        User GetWithId(int id);
        List<User> GetAll();
    }
}
