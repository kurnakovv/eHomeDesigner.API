using eHomeDesigner.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Contexts
{
    public class FurnitureDbContext : DbContext
    {
        public FurnitureDbContext(DbContextOptions<FurnitureDbContext> options) : base(options) { }

        public DbSet<FurnitureEntity> Furnitures { get; set; }
    }
}
