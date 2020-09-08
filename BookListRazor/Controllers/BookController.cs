using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly Context _db;

        public BookController(Context db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _db.Books.ToList() });
        }
    }
}
