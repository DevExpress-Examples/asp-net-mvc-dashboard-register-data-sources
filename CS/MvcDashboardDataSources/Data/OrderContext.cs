namespace MvcDashboardDataSources
{
    using System.Data.Entity;

    public partial class OrderContext : DbContext
    {
        public OrderContext()
            : base("name=OrderContext")
        {
        }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);
        }
    }
}
