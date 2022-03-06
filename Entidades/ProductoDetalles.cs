using System.ComponentModel.DataAnnotations;

namespace ExamenBlazor.Entidades{

public partial class ProductoDetalle
{
    [Key]
    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string? Descripcion { get; set; }
    public double Cantidad { get; set; }
    public double Precio { get; set; }

    public ProductoDetalle( string descripcion, double cantidad, double precio)
    {
        Descripcion= descripcion;
        Cantidad = cantidad;
        Precio = precio;
    }
}
}