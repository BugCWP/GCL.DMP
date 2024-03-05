using DMP.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DMP.Repository
{
    public class DMPDbContext : DbContext
    {
        public DMPDbContext(DbContextOptions<DMPDbContext> options) : base(options)
        {
        }

        public DbSet<DocNodeEntity> DocNodes { get; set; }
    }
}
