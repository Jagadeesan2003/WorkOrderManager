using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderManager.Models;

namespace WorkOrderManager.Data
{
    public class WOContext : DbContext
    {
        public WOContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<WorkOrder> WorkOrder { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
