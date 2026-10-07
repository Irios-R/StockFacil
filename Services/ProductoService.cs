public class ProductoService : IProductoService
{
    private readonly IProductoRepository _repository;

    public ProductoService(IProductoRepository repository)
    {
        _repository = repository;
    }

    public async Task<Producto> CrearProductoAsync(Producto nuevoProducto)
    {
        if (nuevoProducto.Precio <= 0)
        {
            throw new ArgumentException("El precio del producto debe ser mayor a cero.");
        }

        if (string.IsNullOrWhiteSpace(nuevoProducto.Nombre))
        {
            throw new ArgumentException("El nombre del producto no puede estar vacío.");
        }

        // Si pasa las validaciones, se guarda en la base de datos
        return await _repository.AddAsync(nuevoProducto);
    }
}
