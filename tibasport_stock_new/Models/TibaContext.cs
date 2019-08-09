using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace tibasport_stock_new.Models
{
    public partial class TibaContext : DbContext
    {
        public TibaContext()
        {
        }

        public TibaContext(DbContextOptions<TibaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Balance> Balance { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<ItemMaster> ItemMaster { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<MajorGp> MajorGp { get; set; }
        public virtual DbSet<Mark> Mark { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<TransDetail> TransDetail { get; set; }
        public virtual DbSet<TransHeader> TransHeader { get; set; }
        public virtual DbSet<TransType> TransType { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\sql2017;Database=F:\\CODE PROJECT\\C#\\TIBASPORT_STOCK_NEW\\TIBASPORT_STOCK_NEW\\TIBASPORT_DB.MDF;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.HasKey(e => e.Year)
                    .HasName("PK__balance__809A238A8590AF83");

                entity.ToTable("balance");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .ValueGeneratedNever();

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemDesc)
                    .HasColumnName("item_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.Store)
                    .HasColumnName("store")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("color");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.ToTable("item_master");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemDesc)
                    .HasColumnName("item_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorGp)
                    .IsRequired()
                    .HasColumnName("major_gp")
                    .HasMaxLength(50);

                entity.Property(e => e.Mark)
                    .IsRequired()
                    .HasColumnName("mark")
                    .HasMaxLength(50);

                entity.Property(e => e.Reorder)
                    .HasColumnName("reorder")
                    .HasMaxLength(50);

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(50);

                entity.Property(e => e.Store)
                    .HasColumnName("store")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(10);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MajorGp>(entity =>
            {
                entity.ToTable("major_gp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.ToTable("mark");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("size");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("store");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransDetail>(entity =>
            {
                entity.HasKey(e => e.TransNo)
                    .HasName("PK__tmp_ms_x__3214EC07051A3AD5");

                entity.ToTable("trans_detail");

                entity.Property(e => e.TransNo).HasColumnName("trans_no");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasMaxLength(50);

                entity.Property(e => e.Store)
                    .HasColumnName("store")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalPerItem)
                    .HasColumnName("total_per_item")
                    .HasMaxLength(50);

                entity.Property(e => e.TransDate)
                    .IsRequired()
                    .HasColumnName("trans_date")
                    .IsRowVersion();

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("trans_type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransHeader>(entity =>
            {
                entity.HasKey(e => e.TransNo)
                    .HasName("PK__trans_he__438CA4F306B74811");

                entity.ToTable("trans_header");

                entity.Property(e => e.TransNo).HasColumnName("trans_no");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .IsRowVersion();

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransType>(entity =>
            {
                entity.ToTable("trans_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("unit");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });
        }
    }
}
