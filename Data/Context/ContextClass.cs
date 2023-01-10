using Ex_ample.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ex_ample.Data.Context
{
    public class ContextClass : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=LIFESAVERHOSPITALAPP;Uid=root;Pwd=Akanniade06", new MySqlServerVersion(new Version("7.0.0")));
        }
        public DbSet<Doctors> Doctors
        {
            get; set;
        }
        public DbSet<Nurses> Nurses
        {
            get; set;
        }
        public DbSet<ElifeSaverManagement> ElifeSaverManagements
        {
            get; set;
        }
        public DbSet<NonMedicalStaff> NonMedicalStaffs
        {
            get; set;
        }
        public DbSet<User> Users { get; set; }
    }
}