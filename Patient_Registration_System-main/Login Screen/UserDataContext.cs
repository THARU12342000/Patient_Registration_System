using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    public class UserDataContext: DbContext
    {
        /*public readonly string path = @"F:\GUI and Data structures\Login Screen\DataFile.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={path}");
        }
        */protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DataFile.db");
        }

        public DbSet<Admin> Admins{ get; set; }

        public DbSet<Teacher> Teachers{ get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Result> Results { get; set; }




    }


}
