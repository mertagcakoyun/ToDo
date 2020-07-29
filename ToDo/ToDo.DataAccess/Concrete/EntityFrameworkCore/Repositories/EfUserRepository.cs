using System;
using System.Collections.Generic;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    class EfUserRepository : IUserBranch
    {
        public void Delete(User table)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetWithId(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(User table)
        {
            throw new NotImplementedException();
        }

        public void Update(User table)
        {
            throw new NotImplementedException();
        }
    }
}
