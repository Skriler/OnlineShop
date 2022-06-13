using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Pages
{
    public class ProductListModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Product> DisplayedProductList { get; private set; }

        public ProductListModel(ApplicationContext db)
        {
            _context = db;
        }

        public async Task OnGetAsync()
        {
            DisplayedProductList = await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task OnPostPriceMoreThanAsync(int price)
        {
            DisplayedProductList = await _context.Products.AsNoTracking().Where(p => p.Price > price).ToListAsync();
        }

        public async Task OnPostPriceLessThanAsync(int price)
        {
            DisplayedProductList = await _context.Products.AsNoTracking().Where(p => p.Price < price).ToListAsync();
        }

        public async Task OnPostByProducerAsync(string producer)
        {
            if (producer == null)
                DisplayedProductList = await _context.Products.AsNoTracking().ToListAsync();
            else
                DisplayedProductList = await _context.Products.AsNoTracking().Where(p => p.Producer.Contains(producer)).ToListAsync();
        }

        public async Task OnPostSortByPriceAsync()
        {
            DisplayedProductList = await _context.Products.AsNoTracking().OrderBy(p => p.Price).ToListAsync();
        }

        public async Task OnPostSortByProducerAsync()
        {
            DisplayedProductList = await _context.Products.AsNoTracking().OrderBy(p => p.Producer).ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            Product product = await _context.Products.FindAsync(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
