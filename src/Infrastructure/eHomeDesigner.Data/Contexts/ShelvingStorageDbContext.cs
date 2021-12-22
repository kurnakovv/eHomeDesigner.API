using eHomeDesigner.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Contexts;

public class ShelvingStorageDbContext : DbContext
{
    public ShelvingStorageDbContext(DbContextOptions<ShelvingStorageDbContext> options) : base(options) { }

    public DbSet<ShelvingStorageEntity> ShelvingStorage { get; set; }
}
