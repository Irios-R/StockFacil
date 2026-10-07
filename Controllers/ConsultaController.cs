using StockFacil.Models;
using StockFacil.Services;
using System.Collections.Generic;

namespace StockFacil.Controllers
{
    public class ConsultaController
    {
        private readonly ConsultaService _service;

        public ConsultaController(ConsultaService service)
        {
            _service = service;
        }

        public List<ProductoConsultaDto> ObtenerResultadosBusqueda(string nombre)
        {
            return _service.BuscarPorNombre(nombre);
        }

        public List<ProductoConsultaDto> ObtenerAlertaBajoStock(int limite)
        {
            return _service.ReporteBajoStock(limite);
        }
    }
}