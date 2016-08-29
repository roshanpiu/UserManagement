using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserManagementDAL.Entities;

namespace UserManagementDAL
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=MITRAI-ROSHANP;Database=temp;Trusted_Connection=True;");
            optionsBuilder.UseNpgsql("User ID=mfmryyzwaglwnw;Password=0bMFpyf1_MY8b4DbukDx8IfGly;Host=ec2-54-243-235-107.compute-1.amazonaws.com;Port=5432;Database=ddkaglp3m98t7o;Pooling=true;SSL Mode=Require;Trust Server Certificate=true;");
        }
    }
}
