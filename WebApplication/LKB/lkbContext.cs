using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication.LKB
{
    public partial class lkbContext : DbContext
    {
        public lkbContext()
        {
        }

        public lkbContext(DbContextOptions<lkbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Morakhasi> Morakhasi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=ruutAa;database=lkb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Members>(entity =>
            {
                entity.ToTable("members", "lkb");

                entity.HasIndex(e => e.User)
                    .HasName("distincty")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Morakhasi>(entity =>
            {
                entity.ToTable("morakhasi", "lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EHour)
                    .HasColumnName("eHour")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsHour)
                    .HasColumnName("isHour")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDate)
                    .HasColumnName("mDate")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.NowDate)
                    .HasColumnName("nowDate")
                    .HasColumnType("date");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("int(5)");

                entity.Property(e => e.SHour)
                    .HasColumnName("sHour")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });
        }
    }
}
