using Microsoft.EntityFrameworkCore.Query.Internal;
using RecipeBookExample.Models;

namespace RecipeBookExample.Repositories
{
    public class RecipeRepository : IRepository<RecipeModel>
    {
        private RecipeBookContext context;
        public RecipeRepository(RecipeBookContext db) 
        {
            context = db;
        }
        public void Create(RecipeModel entity)
        {
            
        }

        public void Delete(RecipeModel entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecipeModel> GetAll()
        {
            return context.Recipes.ToList();
        }

        public RecipeModel GetByID(int id)
        {
            return context.Recipes.Where(r =>r.Id == id).FirstOrDefault();   
        }

        public void Update(RecipeModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
