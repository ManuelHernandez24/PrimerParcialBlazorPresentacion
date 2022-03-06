using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenBlazor.Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoId {get; set;}

        [Required(ErrorMessage = "No puede dejar la descripcion vacia.")]
        [MinLength(3, ErrorMessage = "La descripcion al menos {1} caracteres")]
        [MaxLength(50, ErrorMessage = "La descripcion no puede exceder {1} caracteres")]
        public string Descripcion {get; set;}

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "La existencia debe ser mayor a {1} y menor a {2}")]
        public float Existencia {get; set;}

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "El costo debe ser mayor a {1} y menor a {2}")]
        public float Costo {get; set;}

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "El precio debe ser mayor a {1} y menor a {2}")]
        public float Precio {get; set;}

        [Required]
        public DateTime FechaExpiracion {get; set; } = DateTime.Now;

        [Required]
        [Range(0, 100, ErrorMessage = "La ganancia debe ser mayor entre 1 y 100")]
        public float Ganancia {get; set;}
        public float ValorInventario {get; set;}

        [ForeignKey("ProductoId")]

         public virtual List<ProductoDetalle> ProductoDetalle {get;set;} = new List<ProductoDetalle>();
        
        //ProductoId, Descripcion, Existencia, Costo y ValorInventario
    }
}