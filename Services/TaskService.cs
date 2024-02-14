using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TaskService : ITaskService
    {
        public Task<Model.Task> CreateTask(Model.Task task)
        {
            throw new NotImplementedException();
        }

        public Task<Model.Task> DeleteTask(Model.Task task)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Model.Task>> GetTasks()
        {
            throw new NotImplementedException();
        }

        public Task<Model.Task> UpdateTask(Model.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
