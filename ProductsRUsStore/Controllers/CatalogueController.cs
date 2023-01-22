using Microsoft.AspNetCore.Mvc;
using ProductsRUsStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductsRUsStore.Controllers
{
    public class CatalogueController : Controller
    {
        private IStoreRepository repository;
        private Cart cart;
        public CatalogueController(IStoreRepository repository, Cart cart)
        {
            this.repository = repository;
            this.cart = cart;
        }

        [Route("Catalogue")]
        [Route("Catalogue/{category}")]
        public IActionResult Index(string category = null)
        {
            ViewBag.pageName = "Catalogue";
            ViewBag.cartCount = cart.CountCartItems();
            return View(repository.Products.Where(p => category == null || p.Category == category));
        }

        [Route("Product/{productId}")]
        public IActionResult ProductDetails(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            ViewBag.cartCount = cart.CountCartItems();
            return View(product);
        }
    }
}