using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interfaces;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly EfUserRepository efUserRepository;
        public UserManager()
        {
            efUserRepository = new EfUserRepository();
        }
        public void Delete(User table)
        {
            efUserRepository.Delete(table);
        }

        public List<User> GetAll()
        {
            return efUserRepository.GetAll();
        }

        public User GetWithId(int id)
        {
            return efUserRepository.GetWithId(id);
        }

        public void Save(User table)
        {
            efUserRepository.Save(table);
        }

        public void Update(User table)
        {
            efUserRepository.Update(table);
        }
    }
}
