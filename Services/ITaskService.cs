using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ITaskService
    {
        Task<List<Model.Task>> GetTasks();
        Task<Model.Task> CreateTask(string name);
        Task<Model.Task> DeleteTask(Guid taskId);
        Task<Model.Task> UpdateTask(Model.Task task);
    }
}
