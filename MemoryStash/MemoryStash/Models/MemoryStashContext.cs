using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MemoryStash.Models
{
    public partial class MemoryStashContext : DbContext
    {
        public MemoryStashContext()
        {
        }

        public MemoryStashContext(DbContextOptions<MemoryStashContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<ContainerTag> ContainerTags { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemTag> ItemTags { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MemoryStash;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Container>(entity =>
            {
                entity.ToTable("Container");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Container_User");
            });

            modelBuilder.Entity<ContainerTag>(entity =>
            {
                entity.ToTable("ContainerTag");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.ContainerTags)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("FK_ContainerTag_Container2");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ContainerTags)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_ContainerTag_Tag");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Container");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_User");
            });

            modelBuilder.Entity<ItemTag>(entity =>
            {
                entity.ToTable("ItemTag");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemTags)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemTag_Item1");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ItemTags)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_ItemTag_Tag");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.TagName).HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
