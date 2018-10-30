using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infastructure;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;

        public CartController(IProductRepository repo)
        {
            repository = repo;
        }

        public RedirectToRouteResult AddToCart(int productID, string returnURL)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnURL });
        }
        public RedirectToRouteResult RemoveFromCart(int productID, string returnURL)
        {
            Product product = Repository.Products
            .FirstOrDefault(p => p.ProductID == productID);

            if (product != null)
            {
                GetCart().RemoveItem(product);
            }
            return RedirectToAction("Index", new { returnURL });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}