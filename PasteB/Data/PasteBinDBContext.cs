using Microsoft.EntityFrameworkCore;
using PasteB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasteB.Data
{
    public class PasteBinDBContext : DbContext
    {
        public PasteBinDBContext(DbContextOptions<PasteBinDBContext> options) : base(options)
        {
            
        }
        
        public DbSet<PasteBinModel> PasteBins { get; set; }
    }
}
