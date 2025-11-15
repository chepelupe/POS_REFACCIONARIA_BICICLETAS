using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace pos_proyecto
{
    public static class DatosCompartidos
    {
        public static List<string> Categorias { get; set; } = new List<string>
        {
            "Electrónicos", "Ropa", "Hogar", "Deportes"
        };

        public static List<string> CategoriasProveedores { get; set; } = new List<string>
        {
            "Refacciones", "Servicios", "General"
        };

        // BindingList - SE ACTUALIZA AUTOMÁTICAMENTE
        public static BindingList<Producto> Productos { get; set; } = new BindingList<Producto>();
        public static BindingList<Proveedor> Proveedores { get; set; } = new BindingList<Proveedor>();

        // Eventos para categorías y proveedores
        public static event Action CategoriasActualizadas;
        public static event Action CategoriasProveedoresActualizadas;
        public static event Action ProveedoresActualizados;

        // Contadores para IDs automáticos
        private static int contadorId = 1;
        private static int contadorProveedorId = 1;

        public static void AgregarProducto(Producto producto)
        {
            if (producto != null)
            {
                if (producto.Id == 0)
                {
                    producto.Id = contadorId++;
                }
                Productos.Add(producto); // Se actualiza automáticamente en el DataGridView
            }
        }

        public static void EliminarProductoForzado(int id)
        {
            var producto = Productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                // Crear una nueva lista sin el producto a eliminar
                var nuevaLista = new BindingList<Producto>();
                foreach (var p in Productos)
                {
                    if (p.Id != id)
                        nuevaLista.Add(p);
                }

                // Reemplazar la lista completa
                Productos.Clear();
                foreach (var p in nuevaLista)
                {
                    Productos.Add(p);
                }
            }
        }

        // Métodos para categorías
        public static void AgregarCategoria(string categoria)
        {
            if (!string.IsNullOrWhiteSpace(categoria) && !Categorias.Contains(categoria))
            {
                Categorias.Add(categoria);
                CategoriasActualizadas?.Invoke(); // Disparar el evento
            }
        }

        public static void EliminarCategoria(string categoria)
        {
            if (Categorias.Contains(categoria))
            {
                Categorias.Remove(categoria);
                CategoriasActualizadas?.Invoke(); // Disparar el evento
            }
        }

        // NUEVO MÉTODO: Modificar categoría
        public static void ModificarCategoria(string categoriaVieja, string categoriaNueva)
        {
            if (!string.IsNullOrWhiteSpace(categoriaVieja) &&
                !string.IsNullOrWhiteSpace(categoriaNueva) &&
                Categorias.Contains(categoriaVieja) &&
                !Categorias.Contains(categoriaNueva))
            {
                // Encontrar el índice de la categoría vieja
                int indice = Categorias.IndexOf(categoriaVieja);
                Categorias[indice] = categoriaNueva;

                // Actualizar también los productos que usaban esa categoría
                foreach (var producto in Productos)
                {
                    if (producto.Categoria == categoriaVieja)
                    {
                        producto.Categoria = categoriaNueva;
                    }
                }

                CategoriasActualizadas?.Invoke(); // Disparar el evento
            }
        }

        // Métodos para proveedores
        public static void AgregarProveedor(Proveedor proveedor)
        {
            if (proveedor is null)
            {
                return;
            }

            if (proveedor.Id == 0)
            {
                proveedor.Id = contadorProveedorId++;
            }

            Proveedores.Add(proveedor);
            ProveedoresActualizados?.Invoke();
        }

        public static void EliminarProveedor(int proveedorId)
        {
            var proveedor = Proveedores.FirstOrDefault(p => p.Id == proveedorId);
            if (proveedor != null)
            {
                Proveedores.Remove(proveedor);
                ProveedoresActualizados?.Invoke();
            }
        }

        public static void AgregarCategoriaProveedor(string categoria)
        {
            if (!string.IsNullOrWhiteSpace(categoria) && !CategoriasProveedores.Contains(categoria))
            {
                CategoriasProveedores.Add(categoria);
                CategoriasProveedoresActualizadas?.Invoke();
            }
        }

        public static void EliminarCategoriaProveedor(string categoria)
        {
            if (CategoriasProveedores.Contains(categoria))
            {
                CategoriasProveedores.Remove(categoria);
                CategoriasProveedoresActualizadas?.Invoke();
            }
        }

        public static void ModificarCategoriaProveedor(string categoriaVieja, string categoriaNueva)
        {
            if (!string.IsNullOrWhiteSpace(categoriaVieja) &&
                !string.IsNullOrWhiteSpace(categoriaNueva) &&
                CategoriasProveedores.Contains(categoriaVieja) &&
                !CategoriasProveedores.Contains(categoriaNueva))
            {
                int indice = CategoriasProveedores.IndexOf(categoriaVieja);
                CategoriasProveedores[indice] = categoriaNueva;

                foreach (var proveedor in Proveedores)
                {
                    if (proveedor.Categoria == categoriaVieja)
                    {
                        proveedor.Categoria = categoriaNueva;
                    }
                }

                CategoriasProveedoresActualizadas?.Invoke();
                ProveedoresActualizados?.Invoke();
            }
        }
    }
}