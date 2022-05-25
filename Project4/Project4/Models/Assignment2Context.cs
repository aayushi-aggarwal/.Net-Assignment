using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project4.Models
{
    public partial class Assignment2Context : DbContext
    {
        public Assignment2Context()
        {
        }

        public Assignment2Context(DbContextOptions<Assignment2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Assignment2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.JerseyNo)
                    .HasName("UQ__Player__4DCCFEB5D2506AEE")
                    .IsUnique();

                entity.Property(e => e.PlayerId)
                    .HasColumnName("Player_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Male')");

                entity.Property(e => e.JerseyNo).HasColumnName("Jersey_no");

                entity.Property(e => e.PlayerName)
                    .HasColumnName("Player_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sport)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
