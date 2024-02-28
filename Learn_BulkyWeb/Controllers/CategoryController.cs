using Learn_BulkyWeb.Data;
using Learn_BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learn_BulkyWeb.Controllers {
    public class CategoryController : Controller {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext dbContext) {
            
            _db = dbContext;
        }

        public IActionResult Index() {

            List<Category> categoryList = _db.Category.ToList();
            return View(categoryList);
        }
    }
}
