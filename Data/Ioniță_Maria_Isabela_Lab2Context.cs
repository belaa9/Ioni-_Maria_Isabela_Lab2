using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ioniță_Maria_Isabela_Lab2.Models;

namespace Ioniță_Maria_Isabela_Lab2.Data
{
    public class Ioniță_Maria_Isabela_Lab2Context : DbContext
    {
        public Ioniță_Maria_Isabela_Lab2Context (DbContextOptions<Ioniță_Maria_Isabela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ioniță_Maria_Isabela_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ioniță_Maria_Isabela_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Ioniță_Maria_Isabela_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Ioniță_Maria_Isabela_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Ioniță_Maria_Isabela_Lab2.Models.Category> Categories { get; set; }
        public DbSet<Ioniță_Maria_Isabela_Lab2.Models.Book> Books { get; set; }
        public DbSet<Ioniță_Maria_Isabela_Lab2.Models.BookCategory> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookID, bc.CategoryID });

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookID);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryID);
        }
    }
}
