using System;
using System.Collections.Generic;

namespace pos_proyecto.Modelos
{
    public class VentaDto
    {
        public DateTime Fecha { get; set; }
        public int? ClienteId { get; set; }
        public int? UsuarioId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; } = "COMPLETADA";
        public List<VentaItemDto> Items { get; set; } = new List<VentaItemDto>();
    }

    public class VentaItemDto
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}