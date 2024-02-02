using System;
using System.Collections.Generic;

namespace PrimerCRUD.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Clave { get; set; }

    public DateTime? Fecha { get; set; }
}
