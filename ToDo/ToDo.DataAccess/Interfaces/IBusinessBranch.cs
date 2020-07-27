using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Interfaces
{
    public interface IBusinessBranch
    {
        void SaveBusiness(Business business);
        void DeleteBusiness(Business business);
        void UpdateBusiness(Business business);
        Business BringBusinessWithID(int id);
        List<Business> GetAllBusiness();
    }
}
