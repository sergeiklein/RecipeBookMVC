using RecipeBookExample.Models;

namespace RecipeBookExample.Repositories
{
    public class IngredientRepository : IRepository<IngredientModel>
    {
        private RecipeBookContext _context;
        public void Create(IngredientModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IngredientModel entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IngredientModel> GetAll()
        {
            return _context.Ingredients.ToList();
        }

        public IngredientModel GetByID(int id)
        {
            return _context.Ingredients.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Update(IngredientModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
