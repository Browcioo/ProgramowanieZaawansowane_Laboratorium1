using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProgramowanieZaawansowane_Laboratorium1.Models;

namespace ProgramowanieZaawansowane_Laboratorium1.Data1
{
    public class MvcShoppingContext : DbContext
    {
        public MvcShoppingContext(DbContextOptions<MvcShoppingContext> options)
            : base(options)
        {
        }
        public DbSet<Shopping> Shopping { get; set; }
        public DbSet<Movie> Movie { get; set; }
    }
}
