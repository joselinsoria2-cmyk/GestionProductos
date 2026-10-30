using System;
using System.Collections.Generic;
using System.Text;
using GestionProductos.Services.Interface;

namespace GestionProductos.Services
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly List<Producto> _productos;

        public ProductoRepository()
        {
            _productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Torta de chocolate", Precio = 15000m, Categoria = "Tortas", Activo = true },
                new Producto { Id = 2, Nombre = "Medialuna", Precio = 800m, Categoria = "Facturas", Activo = true },
                new Producto { Id = 3, Nombre = "Cheesecake", Precio = 18000m, Categoria = "Tortas", Activo = true },
                new Producto { Id = 4, Nombre = "Vigilante", Precio = 900m, Categoria = "Facturas", Activo = false }
            };
        }

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return _productos.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos;
        }
    }
}
