using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    [DbConfigurationType(typeof(TaskManagerDBConfig))]
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=TaskManagerDB;Trusted_Connection=True;")
        {

        }
        public DbSet<Model.Task> Tasks { get; set; }
    }
}
