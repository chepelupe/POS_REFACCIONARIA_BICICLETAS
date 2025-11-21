namespace pos_proyecto.ViewModels
{
    public class ProductoVM
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }

        // Propiedades para mostrar en UI
        public string PrecioDisplay => $"${PrecioVenta:N2}";
        public string StockDisplay => Stock <= 0 ? "SIN STOCK" : Stock.ToString();
        public bool TieneStock => Stock > 0;
        public bool StockBajo => Stock > 0 && Stock <= StockMinimo;
        public string EstadoStock
        {
            get
            {
                if (Stock <= 0) return "SIN STOCK";
                if (Stock <= StockMinimo) return "STOCK BAJO";
                return "DISPONIBLE";
            }
        }
    }
}