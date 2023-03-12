using Microsoft.AspNetCore.Mvc;
using RecipeBookExample.Models;
using RecipeBookExample.Repositories;

namespace RecipeBookExample.Controllers
{
    public class AuthorController : Controller
    {
        public IRepository<AuthorModel> _authorRepo;

        public AuthorController(IRepository<AuthorModel> authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public ViewResult Index()
        {
            return View(_authorRepo.GetAll());
        }
        public ViewResult Details(int id)
        {
            return View(_authorRepo.GetByID(id));
        }

    }
}
