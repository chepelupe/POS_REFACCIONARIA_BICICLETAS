using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using pos_proyecto.Servicios;
using pos_proyecto.Modelos;

namespace pos_proyecto.Logica
{
    public class VentaManager
    {
        private readonly ApiService _apiService;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        private List<VentaItemDto> _itemsVenta = new List<VentaItemDto>();

        public VentaManager()
        {
            _apiService = new ApiService();
        }

        public async Task<bool> AgregarProductoVentaAsync(int productoId, int cantidad)
        {
            await _semaphore.WaitAsync();
            try
            {
                // Verificar stock en servidor
                var productoResponse = await _apiService.ObtenerProductoAsync(productoId);
                if (!productoResponse.Success || productoResponse.Data.Stock < cantidad)
                    return false;

                var producto = productoResponse.Data;

                // Buscar si ya existe en la venta
                var itemExistente = _itemsVenta.Find(i => i.ProductoId == productoId);
                if (itemExistente != null)
                {
                    itemExistente.Cantidad += cantidad;
                    itemExistente.Subtotal = itemExistente.Cantidad * itemExistente.PrecioUnitario;
                }
                else
                {
                    var nuevoItem = new VentaItemDto
                    {
                        ProductoId = productoId,
                        Cantidad = cantidad,
                        PrecioUnitario = producto.PrecioVenta,
                        Subtotal = producto.PrecioVenta * cantidad
                    };
                    _itemsVenta.Add(nuevoItem);
                }

                return true;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<ApiResponse<bool>> ProcesarVentaAsync(VentaDto venta)
        {
            await _semaphore.WaitAsync();
            try
            {
                venta.Items = new List<VentaItemDto>(_itemsVenta);
                venta.Subtotal = CalcularSubtotal();
                venta.Impuestos = CalcularImpuestos(venta.Subtotal);
                venta.Total = venta.Subtotal + venta.Impuestos;

                var resultado = await _apiService.CrearVentaAsync(venta);

                if (resultado.Success)
                {
                    _itemsVenta.Clear();
                }

                return resultado;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private decimal CalcularSubtotal()
        {
            decimal subtotal = 0;
            foreach (var item in _itemsVenta)
            {
                subtotal += item.Subtotal;
            }
            return subtotal;
        }

        private decimal CalcularImpuestos(decimal subtotal)
        {
            // 16% de IVA - esto puede venir del servidor también
            return subtotal * 0.16m;
        }

        public void RemoverItemVenta(int productoId)
        {
            _itemsVenta.RemoveAll(i => i.ProductoId == productoId);
        }

        public void LimpiarVentaActual()
        {
            _itemsVenta.Clear();
        }

        public List<VentaItemDto> ObtenerItemsVenta()
        {
            return new List<VentaItemDto>(_itemsVenta);
        }

        public decimal ObtenerTotalVenta()
        {
            return CalcularSubtotal() + CalcularImpuestos(CalcularSubtotal());
        }
    }
}