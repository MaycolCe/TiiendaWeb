using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio.")]
        public double Price { get; set; }
        [Required(ErrorMessage = "La Descripción es obligatoria.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "La Categoria es obligatoria.")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "La Imagen es obligatoria.")]
        public string ImageUrl { get; set; }
        [Range(1,100)]
        public int Count { get; set; } = 1;
    }
}
