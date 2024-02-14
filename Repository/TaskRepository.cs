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
        public Task<List<Model.Task>> GetTasks()
        {
            return _dbContext.Tasks.ToListAsync();
        }
    }
}
