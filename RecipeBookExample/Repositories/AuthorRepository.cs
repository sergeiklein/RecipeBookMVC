using RecipeBookExample.Models;

namespace RecipeBookExample.Repositories
{
    public class AuthorRepository : IRepository<AuthorModel>
    {
        private RecipeBookContext _context;
        public void Create(AuthorModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AuthorModel entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorModel> GetAll()
        {
            return _context.Authors.ToList();
        }

        public AuthorModel GetByID(int id)
        {
            return _context.Authors.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Update(AuthorModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
