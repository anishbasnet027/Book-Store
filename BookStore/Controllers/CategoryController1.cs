using Microsoft.AspNetCore.Mvc;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly ApplicationDBContext _db;

        public CategoryController1(ApplicationDBContext db)
        {
            _db=db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
