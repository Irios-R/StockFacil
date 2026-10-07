using StockFacil.Models;
using System.Collections.Generic;
using System.Linq;

namespace StockFacil.Data
{
    public class ProductoRepository
    {
        private readonly List<Producto> _productos = new();

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
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