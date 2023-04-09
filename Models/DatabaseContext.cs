using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Caterer> Caterers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        // public virtual DbSet<ViewHome> ViewHomes { get; set; }

 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Caterer>(entity =>
            {
                entity.HasKey(e => e.Caterid);

                entity.ToTable("Caterer");

                entity.Property(e => e.Caterid).HasColumnName("Caterid");

                entity.Property(e => e.Cateraddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("cateraddress");

                entity.Property(e => e.Cateremail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cateremail");

                entity.Property(e => e.Caterfullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("caterfullname");

                entity.Property(e => e.Catername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("catername");

                entity.Property(e => e.Caterpasss)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("caterpasss");

                entity.Property(e => e.Caterphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("caterphone");

                entity.Property(e => e.MaxPeople)
                    .HasColumnType("int")
                    .HasColumnName("maxPeople");


                entity.Property(e => e.DistrictId)
                    .HasColumnType("int")
                    .HasColumnName("districtId");

                //entity.HasOne(d => d.Districts)
                //     .WithMany(p => p.)
                //     .HasForeignKey(d => d.DistrictId)
                //     .OnDelete(DeleteBehavior.ClientSetNull)
                //     .HasConstraintName("FK_District_Caterer");


                entity.Property(e => e.Caterstatus).HasColumnName("caterstatus");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cusid);

                entity.ToTable("Customer");

                entity.Property(e => e.Cusid).HasColumnName("cusid");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Cusaddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("cusaddress");

                entity.Property(e => e.Cusemail)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cusemail");

                entity.Property(e => e.Cusfullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cusfullname");

                entity.Property(e => e.Cusphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cusphone");

                entity.Property(e => e.Cusstatus).HasColumnName("cusstatus");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userpass");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food");

                entity.Property(e => e.Foodid).HasColumnName("foodid");

                entity.Property(e => e.Caterid).HasColumnName("caterid");

                entity.Property(e => e.Fooddescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("fooddescription");

                entity.Property(e => e.Foodimage)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foodimage");

                entity.Property(e => e.Foodname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foodname");

                entity.Property(e => e.Foodprice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("foodprice");

                entity.Property(e => e.Foodstatus).HasColumnName("foodstatus");

                entity.HasOne(d => d.Cater)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.Caterid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Food_Caterer");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Paymentid).HasColumnName("paymentid");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.Caterid).HasColumnName("caterid");

                entity.Property(e => e.Cusid).HasColumnName("cusid");
                entity.Property(e => e.Orderaddress)
                    .IsRequired(false)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orderaddress");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("delivery_date");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Cater)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Caterid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Caterer");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Cusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Customer");
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.HasKey(e => e.Detailsid);

                entity.Property(e => e.Detailsid).HasColumnName("detailsid");

                entity.Property(e => e.Foodid).HasColumnName("foodid");

                entity.Property(e => e.Paymentid).HasColumnName("paymentid");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.PaymentDetails)
                    .HasForeignKey(d => d.Foodid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentDetails_Food");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentDetails)
                    .HasForeignKey(d => d.Paymentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentDetails_Payment");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("Wishlist");

                entity.Property(e => e.Wishlistid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("wishlistid");

                entity.Property(e => e.Caterid).HasColumnName("caterid");

                entity.Property(e => e.Cusid).HasColumnName("cusid");



                //entity.HasOne(d => d.Cus)
                //    .WithMany(p => p.Wishlists)
                //    .HasForeignKey(d => d.Cusid)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Wishlist_Customer");

                //entity.HasOne(d => d.WishlistNavigation)
                //    .WithOne(p => p.Wishlist)
                //    .HasForeignKey<Wishlist>(d => d.Wishlistid)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Wishlist_Caterer");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.DistrictId)
                   .ValueGeneratedNever()
                   .HasColumnName("districtId");

                entity.Property(e => e.DistrictName).HasColumnName("districtName");

               
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Worker");

                entity.Property(e => e.Workerid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("workerid");

                entity.Property(e => e.Caterid).HasColumnName("caterid");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Wokername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wokername");

                entity.Property(e => e.Workeraddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("workeraddress");

                entity.Property(e => e.Workerphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("workerphone");

                entity.Property(e => e.Workersalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("workersalary");

                entity.Property(e => e.Workertype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("workertype");

                entity.HasOne(d => d.Cater)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.Caterid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Worker_Caterer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
