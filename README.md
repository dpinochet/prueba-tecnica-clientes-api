
# ClientesAPI

ClientesAPI es una API RESTful desarrollada en .NET Core que proporciona operaciones CRUD para la gestión de clientes. Esta API utiliza Entity Framework Core para interactuar con una base de datos y soporta paginación de datos.

## Requisitos Previos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) o superior
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) o [MySQL](https://dev.mysql.com/downloads/) (opcional, dependiendo de la configuración de la base de datos)
- [Git](https://git-scm.com/)

## Instalación

1. **Clonar el repositorio**

   Clona este repositorio en tu máquina local:

   ```bash
   git clone https://github.com/dpinochet/prueba-tecnica-clientes-api.git
   cd prueba-tecnica-clientes-api
   ```

2. **Restaurar dependencias**

   Navega al directorio del proyecto y restaura las dependencias de NuGet:

   ```bash
   dotnet restore
   ```

3. **Configurar la Base de Datos**

   - **Base de Datos en Memoria** (para desarrollo y pruebas):

     No se requiere configuración adicional para utilizar una base de datos en memoria.

   - **SQL Server o MySQL** (para producción):

     Configura la cadena de conexión en `appsettings.json` o en variables de entorno. Ejemplo:

     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=ClientesDB;User Id=your_user;Password=your_password;"
     }
     ```

     Aplica las migraciones a la base de datos:

     ```bash
     dotnet ef database update
     ```

4. **Ejecutar la API**

   Para iniciar la API en modo desarrollo, usa el comando:

   ```bash
   dotnet run
   ```

   La API estará disponible en `http://localhost:5000` por defecto.

## Pruebas Unitarias

Este proyecto incluye pruebas unitarias utilizando xUnit. Para ejecutar las pruebas:

1. **Navega al proyecto de pruebas**

   ```bash
   cd ClientesAPI.Tests
   ```

2. **Ejecutar las pruebas**

   ```bash
   dotnet test
   ```

## Uso

La API expone endpoints para la gestión de clientes, incluyendo operaciones CRUD básicas y paginación de resultados.

### Ejemplo de Solicitud

- **Obtener clientes paginados**

  ```
  GET /api/Clientes/ef?pageNumber=1&pageSize=10
  ```

  Respuesta:

  ```json
  [
    {
      "id": 1,
      "nombre": "Juan Pérez",
      "telefono": "56912345678",
      "pais": "Chile"
    },
    ...
  ]
  ```

## Contribuciones

Si deseas contribuir a este proyecto, por favor abre un *pull request* o reporta un problema en la sección de *issues*.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.
