using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Entity;

namespace EntityFramework
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}