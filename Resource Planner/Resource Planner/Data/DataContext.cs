using Microsoft.EntityFrameworkCore;
using Resource_Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<AddressContext> Address { get; set; }

        public DbSet<CustomerContext> Customer { get; set; }

        public DbSet<FeatureContext> Feature { get; set; }

        public DbSet<MilestoneContext> Milestone { get; set; }

        public DbSet<PersonProjectContext> PersonProjects { get; set; }

    public  DbSet<ProjectContext> Projects { get; set; }

        public DbSet<ResourceRequired> ResourceRequireds { get; set; }

        public DbSet<RolesContext> Roles { get; set; }

        public DbSet<SkillContext> Skills { get; set; }

    }
}
