using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseImplement
{
    public partial class newStockContext : DbContext
    {
        public newStockContext()
        {
        }

        public newStockContext(DbContextOptions<newStockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buy> Buy { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductBuy> ProductBuy { get; set; }
        public virtual DbSet<ProductDelivery> ProductDelivery { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=192.168.0.197;Port=5432;Database=newStock;Username=postgres;Password=04012001");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buy>(entity =>
            {
                entity.ToTable("buy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 10000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Buy)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customerID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 10000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("delivery");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 10000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("workerID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 10000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Number).HasColumnName("number");
            });

            modelBuilder.Entity<ProductBuy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_buy");

                entity.Property(e => e.BuyId).HasColumnName("buyID");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.HasOne(d => d.Buy)
                    .WithMany()
                    .HasForeignKey(d => d.BuyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("buyID");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productID");
            });

            modelBuilder.Entity<ProductDelivery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_delivery");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.DeliveryId).HasColumnName("deliveryID");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.HasOne(d => d.Delivery)
                    .WithMany()
                    .HasForeignKey(d => d.DeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deliveryID");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productID");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("worker");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 10000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
