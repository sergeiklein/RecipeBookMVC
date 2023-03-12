using Microsoft.AspNetCore.Mvc;
using RecipeBookExample.Models;
using RecipeBookExample.Repositories;

namespace RecipeBookExample.Controllers
{
    public class RecipeController : Controller
        
    {
        public IRepository<RecipeModel> _recipeRepo;
        public RecipeController(IRepository<RecipeModel> recipeRepo)
        {
            _recipeRepo= recipeRepo;
        }

        
        public ViewResult Index()
        {
            return View(_recipeRepo.GetAll());
        }

        public ViewResult Details(int Id)
        {
            return View(_recipeRepo.GetByID(Id));
        }
    }
}
