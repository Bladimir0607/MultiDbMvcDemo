# 🧩 MultiDbMvcDemo

Aplicación ASP.NET Core MVC que integra dos bases de datos relacionales distintas utilizando dos DbContext independientes.

---

## 📌 Descripción del Proyecto

**MultiDbMvcDemo** es una aplicación desarrollada en ASP.NET Core MVC (.NET 8) que demuestra cómo consumir y gestionar información desde dos motores de base de datos diferentes dentro de un mismo proyecto:

- SQL Server → Tabla `Pedido`
- MySQL → Tabla `DetallePedido`

El proyecto implementa dos DbContext separados, cada uno configurado con su proveedor correspondiente en Entity Framework Core 8.

El objetivo principal es demostrar la integración multi-base de datos en una arquitectura MVC moderna.

---

## 🏗️ Arquitectura del Sistema

La aplicación sigue el patrón MVC:

- **Models** → Representan las entidades de negocio.
- **Controllers** → Gestionan la lógica y el acceso a datos.
- **Views** → Renderizan la información.
- **Data** → Contiene los DbContext y configuración de base de datos.

Se utilizan dos contextos independientes:

- `SqlServerContext` → Gestiona la tabla `Pedido`
- `MySqlContext` → Gestiona la tabla `DetallePedido`

Cada contexto utiliza su propio proveedor EF Core.

---

## 🎯 Objetivo Académico

Demostrar:

- Configuración de múltiples DbContext
- Integración de distintos motores relacionales
- Uso de EF Core con proveedores diferentes
- Arquitectura MVC aplicada a escenarios multi-base de datos
- Consolidación de información en una sola vista
---

## 📂 Estructura del Proyecto

```
Controllers/
Models/
Data/
Views/
wwwroot/
appsettings.json
Program.cs
```
---
## 🗄️ Estructura de Base de Datos

### SQL Server

Tabla: `Pedido`

- Id (int)
- ClienteNombre (nvarchar)
- Fecha (datetime)

---

### MySQL

Tabla: `DetallePedido`

- Id (int)
- PedidoId (int)
- Producto (varchar)
- Cantidad (int)
- Precio (decimal)

---
## 🔄 Flujo del Sistema

1. El cliente realiza una solicitud HTTP.
2. El `HomeController` recibe la petición.
3. El controlador consulta:
   - SQL Server mediante `SqlServerContext`.
   - MySQL mediante `MySqlContext`.
4. Se combinan los datos en un ViewModel.
5. La vista muestra la información consolidada.

---

## 📊 Diagrama de Flujo

- ### 📖 Explicación del Diagrama

El diagrama representa la arquitectura híbrida del sistema:

- El cliente interactúa con la aplicación ASP.NET Core MVC.
- El controlador centraliza la lógica de negocio.
- Los datos de **Pedido** se obtienen desde SQL Server.
- Los datos de **DetallePedido** se obtienen desde MySQL.
- Ambos resultados se combinan en un ViewModel.
- Finalmente, la vista renderiza la información unificada.

Esto demuestra cómo una sola aplicación puede conectarse y consumir múltiples motores relacionales usando distintos proveedores EF Core sin conflictos.


<img width="1024" height="1536" alt="ChatGPT Image Feb 25, 2026, 10_12_30 PM" src="https://github.com/user-attachments/assets/f5f44885-e6fe-4bb5-acba-33b17543ec84" />

---

## 🛠️ Tecnologías Utilizadas

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core 8
- Microsoft.EntityFrameworkCore.SqlServer (v8)
- Pomelo.EntityFrameworkCore.MySql (v8)
- SQL Server
- MySQL
- Git
- GitHub

---

## 👨‍💻 Integrantes del Grupo 4

Jeurys José Durán Beato - A00115777

Bladimir Ventura - A00115757

Ángel Javier Barrientos - A00115984

Miguel José Saint Hilaire Peña - A00116662

Sean Alcántara Carrera - A00115911 
