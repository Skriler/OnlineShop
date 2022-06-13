using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

using OnlineShop.Models;

namespace OnlineShop.Pages
{
    public class ProductListModel : PageModel
    {
        private List<Product> productList;
        public List<Product> DisplayedProductList { get; private set; }

        public ProductListModel()
        {
            productList = Product.GetProducts();
        }

        public void OnGet()
        {
            DisplayedProductList = productList;
        }

        public void OnPostPriceMoreThan(int price)
        {
            DisplayedProductList = productList.Where(p => p.Price > price).ToList();
        }

        public void OnPostPriceLessThan(int price)
        {
            DisplayedProductList = productList.Where(p => p.Price < price).ToList();
        }

        public void OnPostByProducer(string producer)
        {
            if (producer == null)
                DisplayedProductList = productList;
            else
                DisplayedProductList = productList.Where(p => p.Producer.Contains(producer)).ToList();
        }

        public void OnPostSortByPrice()
        {
            DisplayedProductList = productList.OrderBy(p => p.Price).ToList();
        }

        public void OnPostSortByProducer()
        {
            DisplayedProductList = productList.OrderBy(p => p.Producer).ToList();
        }
    }
}
