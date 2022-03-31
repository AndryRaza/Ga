using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDesAbsencesv1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ga.Services
{
    public class DB : DbContext
    {

        public DbSet<Appartenir> Appartenirs { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Proof> Proofs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AbsencesDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appartenir>()
                .HasKey(pT => new { pT.UserId, pT.PromotionId });
            modelBuilder.Entity<Appartenir>()
                .Property("Archived")
                .HasDefaultValueSql("0");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Proof>()
                .Property("Justify")
                .HasDefaultValueSql("0");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Attendance>()
                .HasKey(pT => new { pT.SeanceId, pT.UserId });
            modelBuilder.Entity<Attendance>()
                .Property("Late")
                .HasDefaultValueSql("0");
            modelBuilder.Entity<Attendance>()
                .Property("MissingType")
                .HasDefaultValueSql("0.0");
            base.OnModelCreating(modelBuilder);
        }
    }
}
