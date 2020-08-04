using System;
using System.Collections.Generic;
using System.Text;

using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Interfaces
{
    public interface ITaskService : IGenericService<Task>
    {
    }
}
