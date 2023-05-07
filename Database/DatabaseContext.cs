using FinalWindow.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Database
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=LAPTOP-C9DUVST2\\SANG;Initial Catalog=Vehicle;Integrated Security=True")
        {

        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<BillFix> BillFixes { get; set; }
        public DbSet<Accessory> Accessories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Directors");
            });

            modelBuilder.Entity<Manager>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Managers");
            });

            modelBuilder.Entity<Customer>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Customers");
            });

            modelBuilder.Entity<FixWorker>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("FixWorkers");
            });

            modelBuilder.Entity<KeepWorker>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("KeepWorkers");
            });

            modelBuilder.Entity<DayKeepContract>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("DayKeepContracts");
            });

            modelBuilder.Entity<InstantKeepContract>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("InstantKeepContracts");
            });

            modelBuilder.Entity<LoanContract>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("LoanContracts");
            });

            modelBuilder.Entity<MonthKeepContract>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("MonthKeepContracts");
            });

            modelBuilder.Entity<WeekKeepContract>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("WeekKeepContracts");
            });

            modelBuilder.Entity<Bicycle>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Bicycles");
            });

            modelBuilder.Entity<Car>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Cars");
            });

            modelBuilder.Entity<Motor>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Motors");
            });

            modelBuilder.Entity<Truck>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Trucks");
            });
        }



    }

}
