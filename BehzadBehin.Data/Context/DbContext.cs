using System;
using Microsoft.EntityFrameworkCore;
using BehzadBehin.Biographies;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BehzadBehin.DbContexes
{
    public class WebsiteDbContext : DbContext
    {
        public WebsiteDbContext (DbContextOptions<WebsiteDbContext> options) : base(options)
        {
            
        }
        DbSet<Biography> Biographies {get; set;}       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; Database=BehzadBehinDB; User Id=sa; Password=s@123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Biography>(ConfigBiography);
        }

        private void ConfigBiography(EntityTypeBuilder<Biography> obj)
        {
            obj.HasKey(x=>x.Id);
        }
    }
}