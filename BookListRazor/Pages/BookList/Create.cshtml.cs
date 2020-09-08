using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Data;
using BookListRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly Context _db;

        public CreateModel(Context db)
        {
            _db = db;
        }

        public Book Book { get; set; }
        public void OnGet()
        {

        }
    }
}
