using System;

namespace pos_proyecto.Modelos
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public string Categoria { get; set; }
        public int? IdProveedor { get; set; }
        public bool Activo { get; set; }
        public string Imagen { get; set; }
    }

    public class ProveedorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }

    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
    }
}