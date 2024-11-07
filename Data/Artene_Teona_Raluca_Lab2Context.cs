using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Artene_Teona_Raluca_Lab2.Models;

namespace Artene_Teona_Raluca_Lab2.Data
{
    public class Artene_Teona_Raluca_Lab2Context : DbContext
    {
        public Artene_Teona_Raluca_Lab2Context (DbContextOptions<Artene_Teona_Raluca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Artene_Teona_Raluca_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Artene_Teona_Raluca_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Artene_Teona_Raluca_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Artene_Teona_Raluca_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
