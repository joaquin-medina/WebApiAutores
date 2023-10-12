using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(10, ErrorMessage = "El campo {0} no debe de tener mas de {1} carácteres.")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }     
    }
}
