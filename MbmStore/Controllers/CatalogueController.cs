using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infastructure;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Products = Repository.Products;

            IList<Book> books = new List<Book>();
            books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Books = books;
            
            IList<MusicCD> musicCDs = new List<MusicCD>();
            musicCDs = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.MusicCDs = musicCDs;

            IList<Movie> movies = new List<Movie>();
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.Movies = movies;

            return View(Repository.Products);
        }
    }
}