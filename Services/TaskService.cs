using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Services
{
    public class TaskService : ITaskService
    {
        ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Creates a Task then returns the created task.
        /// Throws ArgumentNullException if the name is null or empty
        /// </summary>
        public Task<Model.Task> CreateTask(string name)
        {
            if (name == string.Empty)
            {
                throw new ArgumentNullException("name cannot be empty");
            }
            return _repository.CreateTask(name);

        }

        /// <summary>
        /// Deletes a task based on its Id.
        /// Throws ArgumentNullException if the taskId is null or empty
        /// </summary>
        public Task<Model.Task> DeleteTask(Guid taskId)
        {
            if (taskId == Guid.Empty)
            {
                throw new ArgumentNullException("taskId cannot be empty");
            }
            return _repository.DeleteTask(taskId);
        }

        /// <summary>
        /// Get all the tasks with no filters applied
        /// </summary>
        public Task<List<Model.Task>> GetTasks()
        {
            return _repository.GetTasks();
        }

        /// <summary>
        /// Changes the status of a task to "completed" then returns the task
        /// Throws ArgumentNullException if the taskId is null or empty
        /// </summary>
        public Task<Model.Task> CompleteTask(Guid taskId)
        {
           
            if (taskId == Guid.Empty)
            {
                throw new ArgumentNullException("taskId cannot be empty");
            }
           

            return _repository.CompleteTask(taskId);
        }
    }
}
