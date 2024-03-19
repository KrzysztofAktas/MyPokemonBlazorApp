using Microsoft.EntityFrameworkCore;
using MyPokemonBlazorApp.Model;

namespace MyPokemonBlazorApp.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            var dbpath = Path.Join(path, "pokemon.db");
            optionsBuilder.UseSqlite($"Data Source={dbpath}");
        }
    }
}
