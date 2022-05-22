using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionWebApi2102.data
{
    public class WebApi2021Context:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost; initial catalog=sessionWebApi2021;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
