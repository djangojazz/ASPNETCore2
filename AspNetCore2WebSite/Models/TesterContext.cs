using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetCore2WebSite.Models
{
    public partial class TesterContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }

        public TesterContext(DbContextOptions<TesterContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });
        }
    }
}
