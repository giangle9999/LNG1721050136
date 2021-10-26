using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LNG1721050136.Models
{
    public partial class Quanly : DbContext
    {
        public Quanly()
            : base("name=Quanly")
        {
        }

        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecture>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.University)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
