﻿using System;
using System.Collections.Generic;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBusinessRepository : IBusinessBranch
    {
        public void Delete(Business table)
        {
            throw new NotImplementedException();
        }

        public List<Business> GetAll()
        {
            throw new NotImplementedException();
        }

        public Business GetWithId(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Business table)
        {
            throw new NotImplementedException();
        }

        public void Update(Business table)
        {
            throw new NotImplementedException();
        }
    }
}
