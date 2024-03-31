using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
namespace Biblioteca.Controllers
{
    public class LibrosController : Controller
    {

        public IActionResult Index()
        {
            var Libro = GetData();
            return View(Libro);
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }

        public List<Libros> GetData()
        {
            List<Libros> Libro = new List<Libros>();
            Libro.Add(new Libros
            {
                Id = 1,
                FrontPage = "https://images.cdn1.buscalibre.com/fit-in/360x360/03/0a/030a419b5cbfda84843b6b9fdc5d8273.jpg",
                title = "It",
                author = "Stephen King",
                genre = "Terror",
                PublicationDate = 1986,
                CopiesAvailable = 10
            });
            return Libro;
        }
    }
}

