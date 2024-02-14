using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Repository.Context;

namespace Repository.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TaskManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TaskManagerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
