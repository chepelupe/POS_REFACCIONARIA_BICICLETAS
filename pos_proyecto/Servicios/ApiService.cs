using Newtonsoft.Json;
using pos_proyecto.Modelos.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace pos_proyecto.Servicios
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ApiService()
        {
            _baseUrl = "http://localhost:5000/api"; // Tu servidor Python
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string endpoint)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}{endpoint}");
                var content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<ApiResponse<T>>(content);
                    return result;
                }

                return new ApiResponse<T> { Success = false, Error = $"Error: {response.StatusCode}" };
            }
            catch (Exception ex)
            {
                return new ApiResponse<T> { Success = false, Error = ex.Message };
            }
        }

        public async Task<ApiResponse<T>> PostAsync<T>(string endpoint, object data)
        {
            try
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync($"{_baseUrl}{endpoint}", content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<ApiResponse<T>>(responseContent);
                }

                return new ApiResponse<T> { Success = false, Error = responseContent };
            }
            catch (Exception ex)
            {
                return new ApiResponse<T> { Success = false, Error = ex.Message };
            }
        }

        // MÉTODOS ESPECÍFICOS PARA TU POS
        public async Task<ApiResponse<List<ProductoDto>>> ObtenerProductosAsync()
        {
            return await GetAsync<List<ProductoDto>>("/productos");
        }

        public async Task<ApiResponse<ProductoDto>> ObtenerProductoAsync(int id)
        {
            return await GetAsync<ProductoDto>($"/productos/{id}");
        }

        public async Task<ApiResponse<bool>> CrearProductoAsync(ProductoDto producto)
        {
            return await PostAsync<bool>("/productos", producto);
        }

        public async Task<ApiResponse<bool>> ActualizarProductoAsync(int id, ProductoDto producto)
        {
            return await PostAsync<bool>($"/productos/{id}", producto);
        }

        public async Task<ApiResponse<bool>> EliminarProductoAsync(int id)
        {
            return await PostAsync<bool>($"/productos/{id}/eliminar", new { });
        }

        public async Task<ApiResponse<List<ProveedorDto>>> ObtenerProveedoresAsync()
        {
            return await GetAsync<List<ProveedorDto>>("/proveedores");
        }

        public async Task<ApiResponse<bool>> CrearProveedorAsync(ProveedorDto proveedor)
        {
            return await PostAsync<bool>("/proveedores", proveedor);
        }

        public async Task<ApiResponse<bool>> CrearVentaAsync(VentaDto venta)
        {
            return await PostAsync<bool>("/ventas", venta);
        }

        public async Task<ApiResponse<UsuarioDto>> LoginAsync(string usuario, string password)
        {
            return await PostAsync<UsuarioDto>("/auth/login", new { usuario, password });
        }
    }

    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Error { get; set; }
    }
}