using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Data;
using BookListRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly Context _db;

        public IndexModel(Context db)
        {
            this._db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var bookToDelete = await _db.Books.FindAsync(id);

            if (bookToDelete == null)
            {
                return NotFound();
            }

            _db.Books.Remove(bookToDelete);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
