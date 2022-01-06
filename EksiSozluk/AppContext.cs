using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder

         optionBuilder)
        {
            //DESKTOP - S0CBLLS\SQLEXPRESS
            optionBuilder.UseSqlServer(@"server=.\SQLEXPRESS;Database=eksisozluk;uid=sa;pwd=123");

        }
        public DbSet<Entities> Entities { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Comments> Comments { get; set; }



    }
}
