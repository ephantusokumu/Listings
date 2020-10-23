using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Listings.Model;
using Microsoft.AspNetCore.Mvc;

namespace Listings.Controllers

{

    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        public class BookControllers : Controller
        {
            private readonly ApplicationDbContext _db;


            public BookControllers(ApplicationDbContext db)
            {
                _db = db;
            }
            [HttpGet]

            public IActionResult GetAll()
            {
                return Json(new { data = _db.Book.ToList() });
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
