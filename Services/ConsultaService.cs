using StockFacil.Data;
using StockFacil.Models;
using System.Collections.Generic;
using System.Linq;

namespace StockFacil.Services
{
    public class ConsultaService
    {
        private readonly ProductoRepository _productoRepo;
        private readonly StockRepository _stockRepo;

        public ConsultaService(ProductoRepository productoRepo, StockRepository stockRepo)
        {
            _productoRepo = productoRepo;
            _stockRepo = stockRepo;
        }

        public List<ProductoConsultaDto> BuscarPorNombre(string termino)
        {
            var productos = _productoRepo.ObtenerTodos();
            
            return productos
                .Where(p => p.Nombre.Contains(termino, StringComparison.OrdinalIgnoreCase))
                .Select(p => new ProductoConsultaDto
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Precio = p.Precio,
                    StockActual = _stockRepo.ObtenerPorProductoId(p.Id)?.Cantidad ?? 0
                })
                .ToList();
        }

        public List<ProductoConsultaDto> ReporteBajoStock(int limiteMinimo = 5)
        {
            var productos = _productoRepo.ObtenerTodos();

            return productos
                .Select(p => new ProductoConsultaDto
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Precio = p.Precio,
                    StockActual = _stockRepo.ObtenerPorProductoId(p.Id)?.Cantidad ?? 0
                })
                .Where(p => p.StockActual <= limiteMinimo)
                .ToList();
        }
    }
}