namespace StockFacil.Models
{
    public class ProductoConsultaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int StockActual { get; set; }
    }
}