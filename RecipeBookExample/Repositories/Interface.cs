namespace RecipeBookExample.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
