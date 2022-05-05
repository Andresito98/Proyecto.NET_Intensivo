


 * Breve explicacion del proyecto.

 Creamos el proyecto en "ASP.NET Core Web API"
 Instalamos las dependencias para que no tengamos problemas ya:
 -->  Swagger ya viene instalada por default
 -->  Microsoft.EntityFrameworkCore.SqlServer
 -->  Microsoft.EntityFrameworkCore.Tools
 -->  Microsoft.VisualStudio.Web.CodeGeneration

 Creamos de lo primero una clase que se va a llamar "Curso" con sus atributos y la enlazamos con "BaseEntity"
 Creamos una clase llamada "BaseEntity"
 Creamos "ConnectionStrings" en appsettings.json
 Creamos "ProjectNetDBContext" --> Para crear la tabla cursos en Base de datos
 Creamos la migracion "add-migration "Create Cursos table"" despues --> "Update-Database -Verbose" --> "Script-Migration "
  * Una vez realizado estos pasos en en la aplicacion " SQL MANAGEM " aparecera la nueva base de datos
  * Y podremos conectar desde el " Explorador de Servidores " de .NET la base de datos que es lo mismo que el " SQL MANAGEM "
  Lo conectaremos poniendo "localhost\SQLEXPRESS" y abajo marcando la base de datos con el nombre que pusimos en "ConnectionStrings" en appsettings.json --> "ProjectNetDB"




