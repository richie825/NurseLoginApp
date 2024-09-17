using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NurseLoginApp.Models
{
    public class NurseDbContext : DbContext
    {
        public DbSet<Nurse> Nurses { get; set; }
    }
}