using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVSite.Models
{
    public class Context : DbContext
    {
        public DbSet<Сourse> Courses { get; set; }
        public Context(DbContextOptions<Context>options): base(options)
        {
            Database.EnsureCreated();
        }

    }
}
