using StockFacil.Services;

namespace StockFacil.Controllers
{
    public class StockController
    {
        private readonly StockService _service;

        public StockController(StockService service)
        {
            _service = service;
        }

        public bool AjustarStock(int productoId, int cantidad)
        {
            try
            {
                _service.ActualizarStock(productoId, cantidad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de inventario: {ex.Message}");
                return false;
            }
        }
    }
}using StockFacil.Services;

namespace StockFacil.Controllers
{
    public class StockController
    {
        private readonly StockService _service;

        public StockController(StockService service)
        {
            _service = service;
        }

        public bool AjustarStock(int productoId, int cantidad)
        {
            try
            {
                _service.ActualizarStock(productoId, cantidad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de inventario: {ex.Message}");
                return false;
            }
        }
    }
}