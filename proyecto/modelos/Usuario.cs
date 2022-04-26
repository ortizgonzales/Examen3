using System.ComponentModel.DataAnnotations;


namespace modelos;

public class Usuario
{
    [Required(ErrorMessage = "El Campo Codigo es Obligatorio")]
    public string cod { get; set; }
    [Required(ErrorMessage = "El Campo Nombre es Obligatorio")]
    public string user { get; set; }
    [Required(ErrorMessage = "El Campo Rol es Obligatorio")]
    public string rol { get; set; }
    public string contra { get; set; }
   
}
