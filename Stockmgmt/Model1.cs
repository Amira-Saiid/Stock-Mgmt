namespace Stockmgmt
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Model1, Stockmgmt.Migrations.Configuration>());
        }
        
        public virtual DbSet<Measure_Unit> Measure_Unit { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Permission_Product> Permission_Product { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transfer_Product> Transfer_Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Measure_Unit>()
                .Property(e => e.Unit_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Measure_Unit>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Measure_Unit)
                .Map(m => m.ToTable("Product_Unit").MapLeftKey("Unit_Id").MapRightKey("Product_Id"));

            modelBuilder.Entity<Permission>()
                .Property(e => e.Permission_Date)
                ;

            modelBuilder.Entity<Permission>()
                .Property(e => e.Permission_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.Permission_Product)
                .WithRequired(e => e.Permission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Per_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Per_Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Per_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Per_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Per_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Per_Website)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Per_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Permissions)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Permission_Product)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Transfer_Product)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Stocks)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("Products_inStocks").MapLeftKey("Product_Id").MapRightKey("Stock_Id"));

            modelBuilder.Entity<Stock>()
                .Property(e => e.Stock_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Stock_Add)
                .IsUnicode(false);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Admin_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Stock>()
                .HasMany(e => e.Transfer_Product)
                .WithRequired(e => e.Stock)
                .WillCascadeOnDelete(false);
        }
    }
}
