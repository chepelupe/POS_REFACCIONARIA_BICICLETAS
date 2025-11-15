# POS Refaccionaria Bicicletas

Aplicación de punto de venta para una refaccionaria de bicicletas construida con Windows Forms sobre .NET 8. El objetivo del repositorio es centralizar la gestión de inventario, categorías de productos, proveedores y flujo de ventas dentro de una sola interfaz de escritorio.

## Arquitectura y componentes

- **Cliente WinForms** (`pos_proyecto/`): contiene formularios para inventario, ventas, gestión de productos y proveedores. `Program.cs` arranca `FormInventario`, hoy el módulo más completo.
- **Capa de datos en memoria** (`DatosCompartidos` + `Producto`): mantiene listas estáticas de productos y categorías mediante `BindingList` para reflejar cambios en la UI en tiempo real.
- **Recursos UI** (`*.Designer.cs` y `*.resx`): definen la construcción de formularios y controles de usuario reutilizables (`controlDeUsuarioAgregarProducto`, `controlDeUsuarioProductosCategorias`).
- **sql/**: reservado para scripts de base de datos; actualmente vacío.

## Dependencias y requisitos

- **SDK**: .NET 8.0 (Windows).
- **Paquetes NuGet**: `MySqlConnector` 2.4.0 ya referenciado en `pos_proyecto.csproj`, aunque todavía no se usa en código.
- **SO**: Windows 10/11 para ejecutar WinForms.

## Estado actual

- Inventario: permite agregar/modificar/eliminar productos, filtrar por nombre/categoría/ID/descripción y mantener categorías sincronizadas entre controles.
- Categorías: los eventos `CategoriasActualizadas` notifican a los controles para recargar listas y permiten agregar, eliminar y renombrar categorías.
- Proveedores y ventas: formularios (`FormMenuAgregarProveedores`, `FormInterfazVentas`, `FormProveedor`) existen pero su lógica está pendiente. `controlDeUsuarioAgregarProveedor.cs` es una copia del control de productos y requiere ajustes.
- Persistencia: todos los datos residen en memoria; no hay integraciones activas con MySQL pese a la dependencia declarada.

## Roadmap y pendientes sugeridos

1. **Persistencia real**: implementar repositorio MySQL para productos/categorías/proveedores y poblar `sql/` con el esquema. Si no se usará aún, retirar temporalmente `MySqlConnector` para mantener limpio el proyecto.
2. **Flujo de proveedores**: crear modelos específicos, reutilizar validaciones e integrar formularios y controles propios (alta, edición, listado).
3. **Interfaz de ventas**: conectar con el inventario para permitir selección de productos, cálculo de totales y registro de tickets.
4. **Validaciones y UX**: extraer validaciones a utilidades compartidas y mejorar mensajes de error/confirmación.
5. **Documentación**: documentar scripts SQL, nombrar responsables de módulos y definir lineamientos de ramas/PRs.

## Cómo ejecutar localmente

### Restaurar dependencias y compilar
 
```powershell
dotnet restore pos_proyecto.sln
dotnet build pos_proyecto.sln
```

### Ejecutar el módulo principal (FormInventario)
 
```powershell
dotnet run --project pos_proyecto/pos_proyecto.csproj
```

> Nota: al no existir base de datos, la aplicación trabaja con datos en memoria y carga algunos ejemplos al abrir `FormInventario` por primera vez.

## Guía para colaboradores

- Revisa los pendientes del roadmap y abre un issue o PR antes de iniciar cambios grandes.
- Si trabajas en persistencia, documenta en `sql/` los scripts necesarios y detalla las variables de conexión en el README o en un archivo `.env.example` (por crear).
- Mantén las convenciones de WinForms (nombres `FormX`, `controlDeUsuarioX`) y agrega comentarios solo donde la lógica no sea evidente.
- Ejecuta `dotnet build` antes de subir cambios para garantizar que los formularios sigan compilando.
