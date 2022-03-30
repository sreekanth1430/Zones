using Microsoft.EntityFrameworkCore;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext()
        {
        }
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }

        public virtual DbSet<BuildingBlock.Zones.Model.CRMIL.Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildingBlock.Zones.Model.CRMIL.Order>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);
            });
        }
    }
}
