namespace WSR_New_Sewing.Core.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<FabricRoll> FabricRoll { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderedProduct> OrderedProduct { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<StageOfExecution> StageOfExecution { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>()
                .HasMany(e => e.FabricRoll)
                .WithRequired(e => e.Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FabricRoll>()
                .HasMany(e => e.Product)
                .WithMany(e => e.FabricRoll)
                .Map(m => m.ToTable("TextileProduct").MapLeftKey("FabricRollId").MapRightKey("ProductArticul"));

            modelBuilder.Entity<Material>()
                .HasMany(e => e.FabricRoll)
                .WithRequired(e => e.Material)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderedProduct)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.NumberOfOrder);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderedProduct)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ArticulOfProduct);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StageOfExecution>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.StageOfExecution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.ManagerId)
                .WillCascadeOnDelete(false);
        }
    }
}
