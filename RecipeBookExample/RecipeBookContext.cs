using Microsoft.EntityFrameworkCore;
using RecipeBookExample.Models;

namespace RecipeBookExample
{
    public class RecipeBookContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MRecipeBook;Trusted_Connection=True;";

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorModel>().HasData(
                new AuthorModel() {  Id = 1, FirstName = "Martha", LastName = "Stewart"});

            modelBuilder.Entity<RecipeModel>().HasData(
                new RecipeModel() { Id = 1, Name = "lasagna", CookTime = 45, Description = "Cheesy Vegitarian Lasagna", AuthorId = 1 },
                new RecipeModel() { Id = 2, Name = "spaghetti", CookTime = 25, Description = "Basil Tomato Sauce with Spaghetti noodles", AuthorId = 1 }
                );
            modelBuilder.Entity<IngredientModel>().HasData(
                new IngredientModel() { Id = 1, Name = "Noodles" },
                new IngredientModel() { Id = 2, Name = "Cheese" },
                new IngredientModel() { Id = 3, Name = "Basil" },
                new IngredientModel() { Id = 4, Name = "Tomato Sauce" }
                );
            modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient() { Id = 1, IngredientID = 1, RecipeId = 1 },
                new RecipeIngredient() { Id = 2, IngredientID = 1, RecipeId = 2 },
                new RecipeIngredient() { Id = 3, IngredientID = 2, RecipeId = 1 },
                new RecipeIngredient() { Id = 4, IngredientID = 3, RecipeId = 2 },
                new RecipeIngredient() { Id = 5, IngredientID = 4, RecipeId = 1 },
                new RecipeIngredient() { Id = 6, IngredientID = 4, RecipeId = 2 }
                );
                

        }
        public DbSet<RecipeModel> Recipes { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<IngredientModel> Ingredients { get; set;}

        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

    }
}
