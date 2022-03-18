﻿using Microsoft.EntityFrameworkCore;

namespace Inspection
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
           public DbSet<Inspection> Inspections { get; set; }
           public DbSet<InspectionType> InspectionTypes { get; set; }
           public DbSet<Status> statuses { get; set; }
    }
}
