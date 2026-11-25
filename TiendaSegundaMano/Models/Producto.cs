using System;
using System.Collections.Generic;

namespace TiendaSegundaMano.Models;

public class Producto
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public bool AdmiteEnvio { get; set; }
    public decimal CosteEnvio { get; set; }
    public int Categoria { get; set; }
    public int EstadoProducto { get; set; }
    public List<string> Imagenes { get; set; } = new();
}
