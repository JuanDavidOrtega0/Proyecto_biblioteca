using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
namespace Biblioteca.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options){

        }
        public DbSet<MVC> MVC {get;set;}
    }
}