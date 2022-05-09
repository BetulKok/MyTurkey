using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTurkey.Models
{
    public class UlkeContext: DbContext
    {
        public UlkeContext(DbContextOptions<UlkeContext> options): base(options)
        {

        }

        public DbSet<Bolge> Bolgeler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //model yapıcı , entity model yapıyor, bolge-sehir sınıfından türetiyor datası ulkecontextseeddatadan geliyor,bolgeler-sehirler metodundan.
            modelBuilder.Entity<Bolge>().HasData(UlkeContextSeedData.Bolgeler());
            modelBuilder.Entity<Sehir>().HasData(UlkeContextSeedData.Sehirler());
        }
    }
}
