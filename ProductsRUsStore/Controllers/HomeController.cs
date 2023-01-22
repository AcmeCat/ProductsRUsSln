using Microsoft.AspNetCore.Mvc;
using ProductsRUsStore.Models;

namespace ProductsRUsStore.Controllers
{
    public class HomeController : Controller
    {
        private Cart cart;

        public HomeController(Cart cart)
        {
            this.cart = cart;
        }
        public IActionResult Index()
        {
            ViewBag.pageName = "Home";
            ViewBag.cartCount = cart.CountCartItems();

            return View();
        }
    }
}