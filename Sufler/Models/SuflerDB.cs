using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sufler.Models
{
    public partial class SuflerDB : DbContext
    {
        public SuflerDB()
            : base("name=SuflerDB")
        {
        }

        public virtual DbSet<participant> participants { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<response> responses { get; set; }
        public virtual DbSet<review> reviews { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tag> tags { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<project>()
                .HasMany(e => e.participants)
                .WithRequired(e => e.project)
                .HasForeignKey(e => e.id_project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<project>()
                .HasMany(e => e.responses)
                .WithRequired(e => e.project)
                .HasForeignKey(e => e.id_project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<review>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<tag>()
                .HasMany(e => e.projects)
                .WithOptional(e => e.tag)
                .HasForeignKey(e => e.tags);

            modelBuilder.Entity<user>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.bio)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.participants)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.id_user);

            modelBuilder.Entity<user>()
                .HasMany(e => e.projects)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.creator);

            modelBuilder.Entity<user>()
                .HasMany(e => e.responses)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.id_user);

            modelBuilder.Entity<user>()
                .HasMany(e => e.reviews)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.recepient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.reviews1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.reviewer);
        }
    }
}
