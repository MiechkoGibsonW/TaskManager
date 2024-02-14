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
        Task<Model.Task> CreateTask(Model.Task task);
        Task<Model.Task> DeleteTask(Model.Task task);
        Task<Model.Task> UpdateTask(Model.Task task);
    }
}
