using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using itLab4_5MVC_MSSQL.Models;

namespace itLab4_5MVC_MSSQL
{
    public partial class itSUTBDContext : DbContext
    {
        public itSUTBDContext()
        {
        }

        public itSUTBDContext(DbContextOptions<itSUTBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Column> Column { get; set; }
        public virtual DbSet<Data> Data { get; set; }
        public virtual DbSet<DataBase> DataBase { get; set; }
        public virtual DbSet<Row> Row { get; set; }
        public virtual DbSet<Table> Table { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MAKSYMPC\\SQLEXPRESS;Database=itSUTBD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Column>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.Column)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Column_Table");
            });

            modelBuilder.Entity<Data>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColumnId).HasColumnName("column_id");

                entity.Property(e => e.Data1).HasColumnName("data");

                entity.Property(e => e.RowId).HasColumnName("row_id");

                entity.HasOne(d => d.Column)
                    .WithMany(p => p.Data)
                    .HasForeignKey(d => d.ColumnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Data_Column");

                entity.HasOne(d => d.Row)
                    .WithMany(p => p.Data)
                    .HasForeignKey(d => d.RowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Data_Row");
            });

            modelBuilder.Entity<DataBase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Row>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.Row)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Row_Table");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DbId).HasColumnName("db_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.HasOne(d => d.Db)
                    .WithMany(p => p.Table)
                    .HasForeignKey(d => d.DbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_DataBase");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
