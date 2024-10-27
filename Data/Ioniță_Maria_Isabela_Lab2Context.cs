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
    }
}
