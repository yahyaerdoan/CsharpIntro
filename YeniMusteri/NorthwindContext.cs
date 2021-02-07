using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace YeniMusteri
{
    class NorthwindContext : DbContext
    {

    }
}
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
}

public DbSet<Product> Products { get; set; }


