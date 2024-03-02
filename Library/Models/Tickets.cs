﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public class Tickets
{
    [Key]
    public int TicketsId { get; set; }

    [Required(ErrorMessage = "El campo Fecha es obligatorio")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [ForeignKey("ClientesId)")]
    public int ClientesId { get; set; }

    [ForeignKey("SistemasId")]
    [Required(ErrorMessage = "El campo Sistema es obligatorio.")]
    public int? SistemasId { get; set; }

    [ForeignKey("PrioridadesId")]
    public int PrioridadesId { get; set; }

    [Required(ErrorMessage = "El campo Solicitado Por se encuentra vacio")]
    public string? SolicitadoPor { get; set; }

    [Required(ErrorMessage = "El Campo Asunto se encuentra vacio")]
    public string? Asunto { get; set; }

    [Required(ErrorMessage = "El campo Descripcion se encuentra vacio")]
    public string? Descripcion { get; set; }
}
