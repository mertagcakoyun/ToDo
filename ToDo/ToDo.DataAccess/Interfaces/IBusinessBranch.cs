using System.Collections.Generic;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Interfaces
{
    public interface IBusinessBranch
    {
        void Save(Business table);
        void Delete(Business table);
        void Update(Business table);
        Business GetWithId(int id);
        List<Business> GetAll();
    }
}
