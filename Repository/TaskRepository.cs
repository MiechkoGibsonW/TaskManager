using Model;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TaskRepository : ITaskRepository
    {
        TaskManagerDbContext _dbContext;
        public TaskRepository(TaskManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Model.Task> CreateTask(string name)
        {
            Model.Task createdTask = _dbContext.Tasks.Add(
                new Model.Task()
                {
                    Name = name,
                    IsCompleted = false
                }
            );
            await _dbContext.SaveChangesAsync();
            return createdTask;
        }

        public Task<List<Model.Task>> GetTasks()
        {
            return _dbContext.Tasks.ToListAsync();
        }
      
        public async Task<Model.Task> CompleteTask(Guid taskId)
        {
            Model.Task existingTask = await _dbContext.Tasks.Where(t => t.Id == taskId).SingleOrDefaultAsync();
            if (existingTask != null)
            {
                existingTask.IsCompleted = true;
                await _dbContext.SaveChangesAsync();
                return existingTask;
            }
            else
            {
                throw new Exception($"Task with id {taskId} was not found and therefore could not be updated");
            }
        }
        public async Task<Model.Task> DeleteTask(Guid taskId)
        {
            Model.Task existingTask = await _dbContext.Tasks.Where(t => t.Id == taskId).SingleOrDefaultAsync();
            if (existingTask != null)
            {
                Model.Task deletedTask = _dbContext.Tasks.Remove(existingTask);
                await _dbContext.SaveChangesAsync();
                return deletedTask;
            }
            else
            {
                throw new Exception($"Task with id {taskId} was not found and therefore could not be deleted");
            }
        }

    
    }
}
