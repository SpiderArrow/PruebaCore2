using System;
using System.Collections.Generic;

namespace PruebaCore2.Models;

public partial class Cliente
{
    public long Id { get; set; }

    public int? CategoriaId { get; set; }

    public int? TipoId { get; set; }

    public string Nombres { get; set; } = null!;

    public string? CodigoCliente { get; set; }

    public string? Apellidos { get; set; }

    public string? Telefonos { get; set; }

    public string? Nit { get; set; }

    public string? Dpi { get; set; }

    public string? Direccion { get; set; }

    public string? Alias { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool IsActive { get; set; }
}
