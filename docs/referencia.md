# Referencia técnica del archivo

Complemento del [README](../README.md): qué hay en cada carpeta, cómo compilar y ejecutar cada programa, y el detalle de Ñ y de Abeona Suite.

## Versiones

| Versión | Fecha | Cambios | Captura |
|---|---|---|---|
| BETA 1.0 | 27 mar 2013 | En C++ y de consola: el usuario escribía comandos y recibía el código | [beta](../capturas/beta.png) |
| 1.0 | 11 abr 2013 | Primera interfaz gráfica, con paneles. Primera versión mostrada al público | [1.0](../capturas/1.0.png) |
| 1.7 | 16 may 2013 | Intento de usar ventanas en lugar de paneles; quedó incompleta | [1.7](../capturas/1.7.png) |
| 2.0 | 16 may 2013 | Retoma las ventanas; se volvió la base de las siguientes versiones | [2.0](../capturas/2.0.png) |
| 3.0 | 24 may 2013 | Barra de herramientas y pantalla de código negra | [3.0](../capturas/3.0.png) |
| 4.0 | 8 jul 2013 | Corrección de errores y más funciones | [4.0](../capturas/4.0.png) |
| 5.0 | 11 ago 2013 | Reescrita desde cero, nueva interfaz y primer validador de licencias | [5.0](../capturas/5.0.png) |
| Validador 1.0 | 13 ago 2013 | Ventana de activación contra la piratería | — |
| 6.0 | oct 2013 | Elección de lenguaje (C++ o C#) e idioma, con barra de estado. **Código en `src/code-generator/`** (ensamblado 5.9.0.0) | [6.0](../capturas/6.0.png) |
| 7.0 BETA | nov 2013 | Captura de la 7.0 en desarrollo | [7.0 BETA](../capturas/7.0-beta.png) |
| Diagram Generator | oct 2013 – jun 2014 | Prototipo para dibujar diagramas de flujo. **Código en `src/diagram-generator/`** | — |
| Console 2.0 | abr 2014 | Consola que traduce comandos en español a C# y los compila; integrada en Code Generator C# 7.0. Antecedente de Ñ | — |
| C++ 6.0 y C# 7.0 | nov 2014 | Code Generator se divide en una aplicación por lenguaje, con archivos de proyecto (`.cgp`, `.cgc`, `.cgv`, `.cg`) y un visor. **Código en `src/code-generator-2014/`** | — |
| DiagramGen | nov 2014 | Diagram Generator rehecho, con proyectos guardados en una base de datos. **Código en `src/diagram-generator-2014/`** | — |
| Abeona Suite | may 2015 | El salto a la web: ASP.NET con cuentas de usuario, generador para C# y VB, y su propio sitio. **Código en `src/abeona-suite-2015/`** | — |
| Compilador Ñ 3.0 | nov 2016 | IDE en WPF para Ñ 2.5. **Código en `src/lenguaje-n/compilador-2016/`** | — |

Las notas originales de cada versión de 2013 están en [`notas-de-version/`](../notas-de-version/).

## Contenido

```
src/
├── code-generator/              2013
│   ├── Abeona CG 6.0.sln        Solución del Code Generator
│   ├── Abeona Compiler/         Code Generator 6.0 (WinForms, C#)
│   ├── validation/              Validador de licencias (con su propia .sln)
│   └── Autorun_abtl-cdgt/       Menú de autorun del CD (con su propia .sln)
├── code-generator-2014/         2014
│   ├── cpp/                     Code Generator C++ 6.0
│   ├── cs/                      Code Generator C# 7.0 (con la consola), Association y CodeGeneratorViewer
│   └── debugger-2014-06/        Formulario suelto de depuración, de junio de 2014
├── abeona-suite-2015/           La suite en la web (ASP.NET), con CodeGen-fuentes/ y App_Data/
├── sitio-selenesoft/            El sitio de SeleneSoft
├── diagram-generator/           2013–2014
│   ├── Diagram Generator.sln
│   └── Diagram Generator/
│       └── res/                 Imágenes de las figuras; deben ir junto al .exe
├── diagram-generator-2014/      Versión de noviembre de 2014
└── lenguaje-n/
    ├── traductor-2014/          El traductor de Ñ y su IDE (Estándar 001)
    ├── compilador-2016/         Compilador Ñ 3.0 (WPF)
    └── interprete-2017/         Proyecto Ñ (.NET Core, esqueleto)
capturas/                        Interfaces de BETA 1.0 a 7.0 BETA (convertidas de BMP a PNG)
notas-de-version/                Notas originales de cada versión
encuesta-2014/                   Datos y gráficas de la encuesta
documentos/                      Estándar de Ñ 001 y manual de Ñ 2.5, las tres fichas técnicas,
                                 el anexo y el guion del concurso, el manual de usuario de Code
                                 Generator, su descripción y los íconos de la suite
```

### Datos de contacto censurados

Los documentos conservan su contenido original; solo se reemplazaron los correos y los teléfonos por marcas de censura, tanto en el texto como en los enlaces que Word guarda por dentro. Lo mismo se hizo en la página de contacto de la suite, en el pie del sitio y en la ventana "Información" del IDE de Ñ. La base de datos de la suite se publica vacía (ver [Abeona Suite](#abeona-suite-2015)).

## Compilar y ejecutar

Son proyectos de Windows.

- **Code Generator (2013 y 2014) y Diagram Generator:** Visual Studio 2010 o posterior, .NET Framework 4.0 (Client Profile), x86, con referencia a `Microsoft.VisualBasic.PowerPacks`.
- **Traductor de Ñ (2014):** Visual Studio 2013 o posterior. El `.csproj` y el `app.config` que se recuperaron ya venían redestinados a .NET Framework 4.8; ese cambio es de 2026, no del código original de 2014.
- **Compilador Ñ 3.0 (2016):** Visual Studio 2015; depende de `SeleneSoftLib.dll`, cuyo código fuente no se conserva.
- **Abeona Suite (2015):** es un despliegue precompilado para IIS con .NET Framework 4.5; no incluye el código C#, que estaba dentro del `.dll` (no incluido).

### Activar Code Generator 6.0 sin comprarlo

Solo Code Generator 6.0 (2013) pide licencia; las versiones de 2014 y Compilador Ñ no.

La licencia son cuatro archivos de texto dentro de esta carpeta. Los nombres en binario significan `ABTL`, `CDGT` y `TRUE`:

```
C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\
```

| Archivo | Contenido |
|---|---|
| `licence.txt` | `1`, sin salto de línea |
| `name.txt` | El nombre que aparecerá en "Acerca de" |
| `languaje.txt` | `1` (español) |
| `lenguaje.txt` | `1` para C++ o `2` para C# |

Escribir en `C:\Archivos de programa` puede requerir permisos de administrador. En Windows en inglés esa carpeta no existe y hay que crearla.

**Con el validador:** `validation.exe` acepta la clave `SS13-ABTL-CDGT-TRY1-FAKE`, pero tiene dos fallos:
- no crea la carpeta, así que hay que crearla antes;
- guarda el idioma y el lenguaje en `language.txt` y `lengprog.txt` en lugar de `languaje.txt` y `lenguaje.txt`, así que después de validar hay que escribir esos dos archivos a mano. Si no, Code Generator falla al arrancar.

## Encuesta 2014

En 2014 se hizo una demostración con encuesta a **41 alumnos** y **16 docentes**. Datos en [`encuesta-2014/`](../encuesta-2014/).

**Alumnos (41)**
- 38 creen que el programa les ayudaría; 36 lo usarían en clase; 34 lo recomendarían.
- 30 lo comprarían.
- 25 lo manejaron con facilidad en la demostración.
- Solo 6 habían programado antes.

**Docentes (16)**
- Los 16 dicen que sus alumnos tienen problemas para aprender a programar, y los 16 creen que el programa les ayudaría.
- 15 lo consideran fácil de usar y 15 lo incluirían en el programa de estudios.
- Calificación promedio: 8.4 de 10.

**Precio:** el precio planteado subió de $300 a $370–400 MXN. En promedio, los encuestados propusieron un precio de $1,151 MXN.

## Lenguaje Ñ (2014–2016)

Lo que se conserva del lenguaje, en orden:

| Fecha | Qué se conserva | Dónde |
|---|---|---|
| abr 2014 | **Code Generator Console 2.0**, el antecedente: comandos en español que se traducen a C# y se compilan | `src/code-generator-2014/cs/Code Generator 6.0/compiler.cs` |
| jul 2014 | **Estándar de Ñ 001**: el documento que define las palabras reservadas y la sintaxis | `documentos/ÑSTD.docx` |
| oct–dic 2014 | **El traductor y su IDE**: la clase `ÑL.toCS()` convierte cada línea de Ñ en C#, dentro de un entorno con ejemplos y reporte de errores | `src/lenguaje-n/traductor-2014/` |
| ene 2015 | Íconos de tipos de archivo de la suite: Ñ aparece junto a C#, C++, VB.NET, HTML, SQL y Java como lenguaje de Compiler y de Code Generator | `documentos/Presentación1.pptx` |
| 2015 | La ficha técnica de Abeona anuncia un "Anexo III: Ñ: Una alternativa a BASIC"; el contenido del anexo no se encontró | `documentos/Ficha Tecnica (enero 2015).docx` |
| 2015 | **Manual "Introducción al lenguaje Ñ"** (v2.5): sintaxis, tipos de datos, entrada y salida, estructuras de control y ejemplos | `documentos/Introduccion al lenguaje Ñ (v2.5).pdf` |
| nov 2016 | **Compilador Ñ 3.0** (IntelINay): IDE de demostración para la versión 2.5 del lenguaje | `src/lenguaje-n/compilador-2016/` |
| ene 2017 | **Proyecto Ñ**: esqueleto de un intérprete en .NET Core con un ejemplo de una sintaxis nueva | `src/lenguaje-n/interprete-2017/` |

> Los enlaces a `selenesoft.net` del manual y el correo de Compilador Ñ ya no pertenecen al proyecto: el dominio se perdió.

### Code Generator Console (2014)

Cada línea empezaba con un comando en español que se traducía a C#:

| Comando | C# generado |
|---|---|
| `INICIO` … `FIN` | Plantilla con `using`, `namespace`, `class Program` y `Main`, y su cierre |
| `USAR x COMO ENTERO` | `int x;` (también `FLOTANTE`, `DOBLE`, `CADENA` y `CARACTER`; sin tipo, `var x;`) |
| `DECLARAR x = 5` | `x = 5;` |
| `IMPRIMIR "texto"` / `SALTO` | `Console.Write("texto");` / `Console.WriteLine("");` |
| `PEDIR x` | `x = Console.ReadLine();` |
| `SI cond` / `NO` / `CERRAR` | `if(cond) {` / `else {` / `}` |
| `MIENTRAS cond` | `while(cond) {` |
| `HACER` … `H-MIENTRAS cond` | `do{` … `}while(cond);` |
| `EN i=1;i<=10;i++` | `for(i=1;i<=10;i++)` |
| `SEGUN x` / `CASO v` / `ROMPER` | `SWITCH(x) {` / `case v:` / `break;` |
| `ESPERAR n` / `PAUSA` / `LIMPIAR` | `System.Threading.Thread.Sleep(n);` / `Console.ReadKey(true);` / `Console.CLEAR();` |

La consola también tenía comandos propios: `GUARDAR`, `VER`, `COMPILAR`, `ABRIR`, `ENVIAR` (manda el código a Code Generator), `REINICIAR`, `AYUDA` y `SALIR`.

Tres comandos generaban C# inválido: `DOBLE` producía `doble`, `SEGUN` producía `SWITCH` en mayúsculas y `LIMPIAR` producía `Console.CLEAR()`.

### Estándar Ñ 001 (2014)

El documento que define el lenguaje, firmado el 22 de julio de 2014. Ahí se explica de dónde viene el nombre: la idea original era "una manera de escribir en C++ pero en español", y por eso se eligió la letra que distingue al español. Al final se descartó la sintaxis de C++, porque habría heredado su dificultad, y se adoptó el seudocódigo que ya usaban los programas anteriores.

Palabras reservadas: `INICIO`, `FIN`, `CÑ:` (comentario), `Imprimir`, `Salto`, `Pedir`, `Usar … como …`, `Declarar`, `Si`, `No`, `Mientras`, `Hacer`, `H-mientras`, `En`, `Según`, `Caso`, `Romper`, `Cerrar`, `Limpiar`, `Pausa` y `Esperar`. Los tipos de dato son `Entero`, `Flotante`, `Doble`, `Carácter` y `Cadena`.

Reglas: la primera línea debe ser `INICIO` y la última `FIN`, ambas en mayúsculas; el resto de las palabras no las llevan obligatoriamente, y el lenguaje no usa acentos.

El estándar reconoce sus límites —solo aplicaciones de consola, sin funciones propias y sin orientación a objetos— y anuncia dos ramas que nunca existieron: ÑWEB para páginas y ÑCBD para bases de datos.

### El traductor (2014)

`Ñ.cs` contiene la clase `ÑL` con el método `toCS(string línea)`, que traduce una línea de Ñ a C#:

| Ñ | C# generado |
|---|---|
| `INICIO` … `FIN` | Plantilla con `using`, `namespace ConsoleApp`, `class Program` y `Main`, y su cierre |
| `IMPRIMIR "texto"` / `SALTO` | `Console.Write("texto");` / `Console.WriteLine("…")` |
| `PEDIR x` | Lectura por teclado |
| `USAR x COMO ENTERO` | `int x;` (también `FLOTANTE`, `DOBLE`, `CADENA` y `CARACTER`) |
| `SI` / `NO` / `CERRAR` | `if(…) {` / `else {` / `}` |
| `MIENTRAS` / `HACER` / `H-MIENTRAS` | `while(…) {` / `do{` / `}while(…);` |
| `EN` | `for(…)` |
| `SEGUN` / `CASO` / `ROMPER` | `SWITCH(…)` / `case …` / `break;` |
| `PAUSA` / `LIMPIAR` | `Console.ReadKey(true);` / `Console.CLEAR();` |
| `CÑ:` | Comentario |

Trae además una tabla de colores que traduce a `Console.ForegroundColor` y `Console.BackgroundColor`. Arrastra dos errores de la consola de 2014: `SEGUN` genera `SWITCH` en mayúsculas y `LIMPIAR` genera `Console.CLEAR()`, que no compilan.

### Ñ 2.5 según su manual (2015)

El manual lo presenta como un lenguaje "con una sintaxis sencilla para que las personas que van entrando en el mundo de los lenguajes de la programación pudieran iniciar su camino con un lenguaje amigable y en su propio idioma".

- **Estructura:** el programa abre con `INICIO` y cierra con `FIN`, siempre en mayúsculas. Va una instrucción por línea, sin `;`, y las palabras clave no llevan acentos.
- **Tipos de datos:** `numerico`, `decimal`, `caracter`, `cadena` y lógico (verdadero o falso). No hay conversión entre tipos.
- **Funciones integradas** (empiezan con mayúscula): `Escribir(cadena)`, `Leer(tipo)` y `Pausa()`. El texto se une con `+`.
- **Control:** `si (…) { } no { }` y `elegir (x) { caso 1: … romper  otro: … romper }`.
- **Ciclos:** `mientras (…) { }`, `hacer { } mientras (…);` y `para (…; …; …) { }`.
- **Límite de la v2.5:** no se pueden declarar funciones ni clases.

Ejemplo del manual, el mayor de dos números:

```
INICIO
hacer{
Escribir(“Introduzca dos valores distintos”)
numerico A = Leer(numerico)
numerico B = Leer(numerico)
}mientras(A == B);
si(A > B)
{
  Escribir(A + “ Es el mayor”)
}
no
{
  Escribir(B + “ Es el mayor”)
}
Pausa()
FIN
```

### Compilador Ñ 3.0 (2016)

- IDE en WPF con cinta de opciones: menús para nuevo proyecto, guardar, exportar a ejecutable o a código fuente, portapapeles, deshacer/rehacer, fuente y ejecutar. Los botones todavía no tienen lógica conectada; al abrir avisa: *"Esta es solo una versión demostrativa del lenguaje Ñ"*.
- Cada proyecto se crea en `C:\Proyectos Ñ\<nombre>\` con un archivo `<nombre>.ñ` y una carpeta `exe`.
- Compila a `.exe` con CodeDom y traduce los errores del compilador de C# al español ("Error en la línea N"). Resta 7 líneas al número de línea, lo que indica que el código Ñ se traducía a C# dentro de una plantilla.
- Incluye un formulario para reportar fallos.
- **No incluye el traductor de la versión 2.5:** no está en el código fuente ni en el ejecutable compilado de esa fecha. El que sí se conserva es el de 2014, que traduce el Estándar 001, con una sintaxis distinta.

### Proyecto Ñ (2017)

Solución de .NET Core 1.0 con una biblioteca `Base` y un `Interprete`, ambos vacíos. Solo conserva, en un comentario, un ejemplo de la sintaxis que se planeaba, ya orientada a objetos. El objetivo de esta etapa, según recuerda el autor, era un Ñ portable como Java pero compilado a código nativo, sin bytecode; la biblioteca `Base` (con espacios como `Base.Plataforma.Windows`) apunta en esa dirección.

```
usar Base;
usar Base.Plataforma.Windows;

paquete HolaMundo
{
    publico clase Programa
    {
        publico estatico Consola Inicio()
        {
        }
    }
}
```

## Abeona Suite (2015)

Aplicación web en ASP.NET Web Forms sobre .NET 4.5, con una página por herramienta:

| Herramienta | Página |
|---|---|
| Code Generator | `Apps/CodeGen/CodeGenCS.aspx` y `CodeGenVB.aspx` |
| Compilador | `Apps/Compiler/CompilerCS.aspx` y `CompilerVB.aspx` |
| Diagram Generator | `Apps/DiagramGen/DiagramGen.aspx` |
| Desk Tester | `Apps/DeskTest/DeskTest.aspx` |
| App Designer | `Apps/AppDes/AppDesigner.aspx` |
| Web Designer | `Apps/WebDes/WebDes.aspx` |
| Editor de texto | `Apps/TextEditor/PowerText.aspx` |

Tiene cuentas de usuario con ASP.NET Identity: registro, inicio de sesión, recuperación de contraseña, verificación por teléfono, autenticación en dos pasos y almacenamiento de archivos por usuario (`Account/MyFiles.aspx`).

- La carpeta es el **despliegue precompilado**, así que conserva el marcado, los estilos y los recursos, pero no el código C#, que estaba dentro del `.dll`. Las páginas de `CodeGen-fuentes/` sí son código original de mayo de 2015.
- **La base de datos se publica vacía.** La original guardaba las cuentas reales de quienes se registraron en 2015, así que `App_Data/` contiene una copia con el esquema y sin datos, generada con `DBCC CLONEDATABASE`. Los detalles están en [`App_Data/LEEME.md`](../src/abeona-suite-2015/App_Data/LEEME.md).
- `src/sitio-selenesoft/` es el sitio de SeleneSoft de esos años, con su página de inicio, registro e inicio de sesión.

## Créditos según los programas

Tal como aparecen en las ventanas "Acerca de".

**Code Generator** (`src/code-generator/Abeona Compiler/Form2.resx`, 2013)
- Idea, diseño de interfaz y algoritmo principal: Néstor Rodríguez
- Colaboración en el diseño y desarrollo: Daniela Delgado, Ismael López

**Lenguaje Ñ y su compilador** (`src/lenguaje-n/traductor-2014/Ñ_/Información.resx`, 2014, y `src/lenguaje-n/compilador-2016/Compilador Ñ/AboutBox1.cs`, 2016)
- Diseño y programación del compilador: Carlos Conchas, Néstor Rodríguez
- Desarrollo del lenguaje: Carlos Conchas, Néstor Rodríguez
