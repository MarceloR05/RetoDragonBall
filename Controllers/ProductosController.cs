using Microsoft.AspNetCore.Mvc;
using RetoDragonBall.Models;

namespace RetoDragonBall.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Titulo"] = "Catálogo de Productos";
            ViewData["Productos"] = ObtenerProductos();

            return View();
        }

        private List<Producto> ObtenerProductos()
        {
            return new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Laptop", Descripcion = "Laptop de última generación", Precio = 1200, Stock = 5, Categoria = "Computación" },
                new Producto { Id = 2, Nombre = "Mouse", Descripcion = "Mouse inalámbrico", Precio = 25, Stock = 50, Categoria = "Accesorios" },
                new Producto { Id = 3, Nombre = "Teclado", Descripcion = "Teclado mecánico", Precio = 60, Stock = 20, Categoria = "Accesorios" },
                new Producto { Id = 4, Nombre = "Monitor", Descripcion = "Monitor Full HD 24\"", Precio = 300, Stock = 10, Categoria = "Computación" },
                new Producto { Id = 5, Nombre = "Silla", Descripcion = "Silla ergonómica", Precio = 150, Stock = 8, Categoria = "Hogar" }
            };
        }
    }
}
