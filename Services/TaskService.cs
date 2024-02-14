using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TaskService : ITaskService
    {
        ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }
        public Task<Model.Task> CreateTask(Model.Task task)
        {
            throw new NotImplementedException();
        }

        public Task<Model.Task> DeleteTask(Model.Task task)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.Task>> GetTasks()
        {
            return  _repository.GetTasks();
        }

        public Task<Model.Task> UpdateTask(Model.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
