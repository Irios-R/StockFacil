using StockFacil.Data;

namespace StockFacil.Services
{
    public class StockService
    {
        private readonly StockRepository _repository;

        public StockService(StockRepository repository)
        {
            _repository = repository;
        }

        public int ActualizarStock(int productoId, int cantidad)
        {
            var stockActual = _repository.ObtenerPorProductoId(productoId)?.Cantidad ?? 0;
            int nuevoStock = stockActual + cantidad;

            if (nuevoStock < 0)
            {
                throw new InvalidOperationException("No hay suficiente stock disponible para realizar la salida.");
            }

            _repository.GuardarOActualizar(productoId, nuevoStock);
            return nuevoStock;
        }

        public int ConsultarUnidades(int productoId)
        {
            return _repository.ObtenerPorProductoId(productoId)?.Cantidad ?? 0;
        }
    }
}