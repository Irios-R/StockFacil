using StockFacil.Services;

namespace StockFacil.Controllers
{
    public class ProductoController
    {
        private readonly ProductoService _service;

        public ProductoController(ProductoService service)
        {
            _service = service;
        }

        public bool CrearProducto(int id, string nombre, decimal precio)
        {
            try
            {
                _service.RegistrarProducto(id, nombre, precio);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}