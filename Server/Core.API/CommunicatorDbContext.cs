using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure
{
    public class CommunicatorDbContext : DbContext
    {
        public CommunicatorDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Communication> Communications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Communication>(entity =>
            {
                entity.Property(e => e.DateSent).HasColumnType("datetimeoffset(0)");

                entity.Property(e => e.From).HasMaxLength(256);

                entity.Property(e => e.Subject).HasMaxLength(256);

                entity.Property(e => e.To).HasMaxLength(1024);
            });
        }
    }
}