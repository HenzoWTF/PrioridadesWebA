using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public class Sistema
{
    [Key]
    public int SistemasId { get; set; }

    [Required(ErrorMessage = "El campo es obligatorio")]
    [RegularExpression(@"^[a-zA-Z\s]+$",
    ErrorMessage = "Debe de insertar un nombre valido")]
    public string? SistemasNombres { get; set; }

}
