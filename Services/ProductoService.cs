using StockFacil.Data;
using StockFacil.Models;

namespace StockFacil.Services
{
    public class ProductoService
    {
        private readonly ProductoRepository _repository;

        public ProductoService(ProductoRepository repository)
        {
            _repository = repository;
        }

        public Producto RegistrarProducto(int id, string nombre, decimal precio)
        {
            if (string.IsNullOrWhiteSpace(nombre) || precio <= 0)
            {
                throw new ArgumentException("El nombre no puede estar vacío y el precio debe ser mayor a 0.");
            }

            var producto = new Producto { Id = id, Nombre = nombre, Precio = precio };
            _repository.Agregar(producto);
            return producto;
        }
    }
}