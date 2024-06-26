using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using Biblioteca.Datos;
using Microsoft.EntityFrameworkCore;
namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index(){
            return View(await _context.MVC.ToListAsync());
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

        public List<Usuarios> GetData()
        {
            List<Usuarios> Usuario = new List<Usuarios>();
            Usuario.Add(new Usuarios
            {
                Id = 1,
                Name = "Juan",
                LastName = "Ortega",
                Nit = 1020102010,
                TypeNit = "Cédula",
                Age = 18,
                Adress = "Calle 123",
                PhoneNumber = "3053051234",
                Email = "juanda@gmail.com"
            });
            Usuario.Add(new Usuarios
            {
                Id = 2,
                Name = "Anthony",
                LastName = "Muñoz",
                Nit = 1020102010,
                TypeNit = "Cédula",
                Age = 21,
                Adress = "Calle 123",
                PhoneNumber = "3053051234",
                Email = "Anthony@gmail.com"
            });
            return Usuario;
        }
    }
}

