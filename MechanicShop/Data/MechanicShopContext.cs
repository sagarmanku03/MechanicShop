using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MechanicShop.Models;

namespace MechanicShop.Data
{
    public class MechanicShopContext : DbContext
    {
        public MechanicShopContext (DbContextOptions<MechanicShopContext> options)
            : base(options)
        {
        }

        public DbSet<MechanicShop.Models.management> management { get; set; }
    }
}
