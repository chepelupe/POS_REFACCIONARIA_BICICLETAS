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

        // BindingList - SE ACTUALIZA AUTOMÁTICAMENTE
        public static BindingList<Producto> Productos { get; set; } = new BindingList<Producto>();

        // Eventos para categorías (los mantenemos)
        public static event Action CategoriasActualizadas;

        // Contador para IDs automáticos
        private static int contadorId = 1;

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
    }
}