# Base de datos de Abeona Suite

`aspnet-Code Generator Web-20150327081754.mdf` es el **esquema de la base original, sin datos**.

La base de 2015 guardaba las cuentas de quienes se registraron en la aplicación: correos y hashes de contraseña de personas reales. Esa versión no se publica.

## Qué contiene

Las seis tablas originales, vacías, con sus columnas, claves e índices tal como estaban:

- `AspNetUsers`, `AspNetRoles`, `AspNetUserRoles`, `AspNetUserClaims`, `AspNetUserLogins` (cuentas de ASP.NET Identity)
- `__MigrationHistory`, con su único registro de Entity Framework, para que la aplicación reconozca la base como actualizada

## Cómo se generó

Con `DBCC CLONEDATABASE ... WITH NO_STATISTICS`, que crea una base nueva copiando solo la estructura. Se eligió ese método en lugar de borrar las filas porque al borrar, los datos siguen presentes dentro del archivo y se pueden recuperar. Aquí nunca llegaron a escribirse: el archivo se revisó y no contiene ningún correo, hash ni ruta personal.

## Cómo usarla

El archivo se generó con SQL Server 2019, así que necesita esa versión o una posterior (LocalDB 2019 en adelante); la original era de 2014. No se incluye el archivo de registro `.ldf`: SQL Server lo crea solo al adjuntar la base, ya sea por la cadena de conexión de `Web.config` o con:

```sql
CREATE DATABASE AbeonaSuite
ON (FILENAME = 'ruta\aspnet-Code Generator Web-20150327081754.mdf')
FOR ATTACH_REBUILD_LOG;
```
