using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationContext _context;

        [BindProperty]
        public Product Product { get; set; }

        public DetailsModel(ApplicationContext db)
        {
            _context = db;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Product = await _context.Products.FindAsync(id);

            if (Product == null)
                return NotFound();

            return Page();
        }
    }
}
