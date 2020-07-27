using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBusinessRepository : IBusinessBranch
    {
        public Business BringBusinessWithID(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteBusiness(Business business)
        {
            throw new NotImplementedException();
        }

        public List<Business> GetAllBusiness()
        {
            throw new NotImplementedException();
        }

        public void SaveBusiness(Business business)
        {
            throw new NotImplementedException();
        }

        public void UpdateBusiness(Business business)
        {
            throw new NotImplementedException();
        }
    }
}
