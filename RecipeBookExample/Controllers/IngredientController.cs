using Microsoft.AspNetCore.Mvc;
using RecipeBookExample.Models;
using RecipeBookExample.Repositories;

namespace RecipeBookExample.Controllers
{
    public class IngredientController : Controller
    {
        public IRepository<IngredientModel> _ingredientRepo;

        public IngredientController(IRepository<IngredientModel> ingredientRepo)
        {
            _ingredientRepo= ingredientRepo;
        }


        public ViewResult Index()
        {
            return View(_ingredientRepo.GetAll());
        }

        public ViewResult Details(int id)
        {
            return View(_ingredientRepo.GetByID(id));
        }
    }
}
