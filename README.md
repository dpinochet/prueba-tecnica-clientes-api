
# ClientesAPI

ClientesAPI es una API RESTful desarrollada en .NET Core que proporciona operaciones CRUD para la gestión de clientes. Esta API utiliza Entity Framework Core para interactuar con una base de datos y soporta paginación de datos.

## Requisitos Previos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) o superior
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) o [MySQL](https://dev.mysql.com/downloads/)
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

   ### Opciones de Configuración:

   - **Base de Datos en Memoria** (para desarrollo y pruebas):

     No se requiere configuración adicional para utilizar una base de datos en memoria.

   - **MySQL** (para desarrollo o producción):

     Si deseas utilizar una base de datos MySQL, sigue estos pasos:

     - Ejecuta el siguiente script SQL para crear la base de datos y la tabla:

       ```sql
       -- Crear la base de datos
       CREATE DATABASE IF NOT EXISTS ClientesDB;

       -- Usar la base de datos
       USE ClientesDB;

       -- Crear la tabla Clientes
       CREATE TABLE IF NOT EXISTS Clientes (
           Id INT AUTO_INCREMENT PRIMARY KEY,
           Nombre VARCHAR(255) NOT NULL,
           Telefono VARCHAR(20) NOT NULL,
           Pais VARCHAR(100) NOT NULL
       );

       -- Insertar datos de ejemplo en la tabla Clientes
       INSERT INTO Clientes (Nombre, Telefono, Pais) VALUES
       ('Juan Pérez', '56912345678', 'Chile'),
       ('María López', '56923456789', 'Argentina'),
       ('Carlos Rodríguez', '56934567890', 'Perú'),
       ('Ana Gómez', '56945678901', 'Chile'),
       ('Luis Fernández', '56956789012', 'Argentina'),
       ('Jorge Martínez', '56967890123', 'Perú'),
       ('Laura Sánchez', '56978901234', 'Chile'),
       ('Pedro Díaz', '56989012345', 'Argentina'),
       ('Carmen Reyes', '56990123456', 'Perú'),
       ('Gabriel Vega', '56901234567', 'Chile'),
       ('Elena Ortega', '56912345678', 'Argentina'),
       ('Manuel Torres', '56923456789', 'Perú'),
       ('Patricia Ramírez', '56934567890', 'Chile'),
       ('Santiago Castro', '56945678901', 'Argentina'),
       ('Adriana Rivas', '56956789012', 'Perú'),
       ('Ricardo Herrera', '56967890123', 'Chile'),
       ('Victoria Núñez', '56978901234', 'Argentina'),
       ('Francisco Morales', '56989012345', 'Perú'),
       ('Claudia Ruiz', '56990123456', 'Chile'),
       ('Andrés Fuentes', '56901234567', 'Argentina');
       ```

     - Configura la cadena de conexión en `appsettings.json` o en variables de entorno. Ejemplo:

       ```json
       "ConnectionStrings": {
         "DefaultConnection": "Server=your_server;Database=ClientesDB;User Id=your_user;Password=your_password;"
       }
       ```

     - Aplica las migraciones a la base de datos (si estás utilizando EF Core con migraciones):

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
