using System;
using System.Collections.Generic;
using System.Text;

namespace GestionProductos.Services.Interface
{
    public interface IProductoRepository
    {
        public void Agregar(Producto producto);

        public List<Producto> ObtenerTodos();

        public Producto? ObtenerPorId(int id);

        public List<Producto> BuscarPorCategoria(string categoria);
    }
}
