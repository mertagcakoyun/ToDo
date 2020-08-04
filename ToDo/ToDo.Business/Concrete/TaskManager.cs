using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interfaces;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    class TaskManager : ITaskService
    {
        private readonly EfTaskRepository efTaskRepository;

        public TaskManager()
        {
            efTaskRepository = new EfTaskRepository();
        }
        public void Delete(Task table)
        {
            efTaskRepository.Delete(table);
        }

        public List<Task> GetAll()
        {
            return efTaskRepository.GetAll();
        }

        public Task GetWithId(int id)
        {
            return efTaskRepository.GetWithId(id);
        }

        public void Save(Task table)
        {
            efTaskRepository.Save(table);
        }

        public void Update(Task table)
        {
            efTaskRepository.Update(table);
        }
    }
}
