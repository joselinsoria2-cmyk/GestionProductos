using GestionProductos;
using GestionProductos.Services;
using GestionProductos.Services.Interface;

IProductoRepository repo = new ProductoRepository();

// 1) Lista completa
Console.WriteLine("=== Todos los productos ===");
foreach (var p in repo.ObtenerTodos())
{
    Mostrar(p);
}

// 2) Buscar por Id (uno que existe y uno que no)
Console.WriteLine("\n=== Buscar por Id ===");
var encontrado = repo.ObtenerPorId(3);
if (encontrado != null)
{
    Mostrar(encontrado);
}
else { 
    Console.WriteLine("No existe el producto 3"); 
}

if (repo.ObtenerPorId(99) == null)
{
    Console.WriteLine("No existe el producto 99");
}

// 3) Filtrar por categoría
Console.WriteLine("\n=== Categoría: Facturas ===");

foreach (var p in repo.BuscarPorCategoria("Facturas"))
{
    Mostrar(p);
}

// 4) Agregar uno nuevo y volver a listar
Console.WriteLine("\n=== Después de agregar ===");

var newProducto = new Producto { Id = 5, Nombre = "Lemon pie", Precio = 14000m, Categoria = "Tortas", Activo = true };

repo.Agregar(newProducto);

foreach (var p in repo.ObtenerTodos())
{
    Mostrar(p);
}

// Función de ayuda para no repetir el mismo WriteLine
void Mostrar(Producto p)
{
    var estado = p.Activo ? "activo" : "inactivo";
    Console.WriteLine($"{p.Id} - {p.Nombre} - ${p.Precio} - {p.Categoria} - {estado}");
}