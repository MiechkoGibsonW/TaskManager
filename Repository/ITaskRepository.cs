using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITaskRepository
    {
        Task<Model.Task> CreateTask(string name);
        Task<Model.Task> DeleteTask(Guid taskId);
        Task<List<Model.Task>> GetTasks();
        Task<Model.Task> CompleteTask(Guid taskId);
    }
}
