using StockFacil.Models;
using System.Collections.Generic;
using System.Linq;

namespace StockFacil.Data
{
    public class StockRepository
    {
        private readonly List<Stock> _inventario = new();

        public Stock? ObtenerPorProductoId(int productoId)
        {
            return _inventario.FirstOrDefault(s => s.ProductoId == productoId);
        }

        public void GuardarOActualizar(int productoId, int nuevaCantidad)
        {
            var item = ObtenerPorProductoId(productoId);
            if (item == null)
            {
                _inventario.Add(new Stock { ProductoId = productoId, Cantidad = nuevaCantidad });
            }
            else
            {
                item.Cantidad = nuevaCantidad;
            }
        }
    }
}