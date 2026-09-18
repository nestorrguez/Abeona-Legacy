# Abeona (2013–2016)

*Memoria de mi primer proyecto de software.*

Estudié la carrera técnica en Programación en el CECyTEN Plantel Tepic de 2012 a 2015. En 2013, a mitad de esos años, empecé Abeona, y seguí trabajando en él hasta 2016, ya fuera de la escuela. Fue, en ese orden, un traductor de seudocódigo a C++ en consola, un generador de código con ventanas, un lenguaje de programación en español y una suite completa en la web. Este repositorio es lo que queda de todo eso.

Es un archivo, no un proyecto activo. Lo reuní a partir de lo que sobrevivió en discos duros viejos, memorias USB y conversaciones de Facebook. Muchos archivos son versiones intermedias, no las que llegué a entregar, así que hay más errores y código inconcluso del que hubo en su momento. Lo publico sin corregirlo, porque su valor está en dejar constancia de lo que hice entonces. Los detalles técnicos —qué carpeta es qué, cómo compilar cada programa, los comandos de Ñ— están en [`docs/referencia.md`](docs/referencia.md).

## El problema que vi (2013)

A mí la programación no me costó. Entendía las clases y el profesor me daba proyectos extra. Lo que me llamó la atención fue lo que pasaba alrededor: la mayoría de mis compañeros resolvía bien los problemas en seudocódigo y se atoraba al traducirlos a C++. No les faltaba lógica; les sobraba sintaxis.

La primera respuesta fue modesta. En marzo de 2013 escribí un programa de consola: le dabas una palabra del seudocódigo y te devolvía su equivalente en C++. Lo llamé Abeona Compiler, un nombre generoso para algo que no compilaba nada. Ni siquiera estoy seguro de que se llamara así desde el principio; puede que le haya puesto el nombre después, cuando ya sabía qué quería construir.

![BETA 1.0](capturas/beta.png)
*BETA 1.0, 27 de marzo de 2013.*

## De la consola a las ventanas

Una consola no convence a nadie. Quien empieza a programar entiende mejor una ventana con botones que una pantalla negra, y yo quería que la herramienta le sirviera justo a esa persona. Por entonces me había marcado la escena de *Piratas de Silicon Valley* en la que Jobs visita Xerox y ve una interfaz gráfica por primera vez; me gustaba pensar que estaba pasando por mi propia versión de ese descubrimiento.

En C++ no lo conseguí: crear una ventana resultó mucho más complicado de lo que esperaba. Buscando alternativas encontré C# y Visual Studio, donde diseñar una aplicación de ventanas era exactamente lo que imaginaba. Desde entonces C# es mi lenguaje.

Con esa base rehíce el proyecto y lo llamé **Code Generator**. La interfaz seguía la lógica de un diagrama de flujo: cada elemento —declarar una variable, mostrar un texto, una condición, un ciclo— tenía su ventana, con los campos necesarios para que el resultado encajara en el lenguaje. Como mis compañeros seguían aprendiendo C++, la primera versión generaba únicamente C++.

Las versiones se sucedieron en pocos meses, y de cada una dejé una nota que se conserva en [`notas-de-version/`](notas-de-version/): la 1.0 en abril, la primera con interfaz gráfica y la primera que mostré en público; la 1.7 y la 2.0 en mayo, cuando pasé de paneles a ventanas; la 3.0 y la 4.0, con barra de herramientas y la pantalla de código en negro, porque la blanca fallaba en algunas computadoras; la 5.0 en agosto, reescrita desde cero; la 6.0 en octubre, que ya generaba C++ o C#; y una 7.0 que se quedó en beta en noviembre. Más de una vez empecé de cero: encontraba en internet una manera mejor de resolver algo que ya funcionaba y prefería reconstruirlo todo.

No lo hice solo todo el tiempo. Invité a amigos a sumarse, a programar lo que faltaba, cazar errores y proponer funciones; Daniela Delgado e Ismael López fueron quienes más aportaron. Con el tiempo cada quien tomó su camino y continué por mi cuenta.

| | | |
|---|---|---|
| ![BETA 1.0](capturas/beta.png) | ![1.0](capturas/1.0.png) | ![1.7](capturas/1.7.png) |
| BETA 1.0 · mar 2013 | 1.0 · abr 2013 | 1.7 · may 2013 |
| ![2.0](capturas/2.0.png) | ![3.0](capturas/3.0.png) | ![4.0](capturas/4.0.png) |
| 2.0 · may 2013 | 3.0 · may 2013 | 4.0 · jul 2013 |
| ![5.0](capturas/5.0.png) | ![6.0](capturas/6.0.png) | ![7.0 BETA](capturas/7.0-beta.png) |
| 5.0 · ago 2013 | 6.0 · oct 2013 | 7.0 BETA · nov 2013 |

## Un producto para vender

Llegó un momento en que Code Generator dejó de parecerme un proyecto escolar y empezó a parecerme un negocio. Si tanta gente había ganado dinero con software, ¿por qué no yo? Lo convertí en producto: CD con autorun, instalador, un validador de licencias, manual de usuario impreso y un precio de entre 370 y 400 pesos. Estaba convencido de tener algo único y lo cuidaba como tal; en esa época creía en el software cerrado.

Alguien mayor me dio un consejo que solo entendí con los años: una idea no se puede guardar bajo llave, tiene que salir al mundo; y el lenguaje y las herramientas con que la había construido eran, al fin y al cabo, de otras personas.

En esa etapa, la maestra Yissell Berenice Dueñas Aguirre me propuso presentar el proyecto en el concurso de creatividad tecnológica en vez de venderlo, y se convirtió en mi asesora. Yo tendía a perderme agregando funciones; ella me hizo escribir la documentación que faltaba y me exigió, con paciencia, una versión terminada, sin piezas a medias. Para convencerme me contó la historia de Pascal y la calculadora a la que siguió añadiendo mecanismos hasta que se quemó sin estar lista. Hoy sé que la anécdota es un mito, y que lo que ella pedía se llama producto mínimo viable. En su momento funcionó.

Para el concurso hicimos una encuesta a 41 alumnos y 16 docentes: 38 alumnos creían que el programa les ayudaría, y los 16 docentes coincidieron en que sus alumnos tenían problemas para aprender a programar (los datos completos están en [`encuesta-2014/`](encuesta-2014/)). Con eso, Code Generator se presentó en el concurso de Tepic en 2014.

## Ñ: escribir en español (2014)

Con los botones de Code Generator llegué hasta cierto punto. El siguiente paso era el que ya tenía la consola original: escribir directamente en español y que el programa tradujera. En abril de 2014 integré a Code Generator una consola que aceptaba comandos como `IMPRIMIR`, `SI`, `MIENTRAS` o `USAR x COMO ENTERO` y los convertía en C#.

Ese seudocódigo se convirtió en un lenguaje. El 22 de julio de 2014 escribí el *Estándar de Ñ 001*, el documento que fija sus palabras reservadas y su sintaxis. Ahí explico el nombre: la idea original era "una manera de escribir en C++ pero en español", y la Ñ es la letra del español. Después descarté la sintaxis de C++, porque habría heredado su dificultad, y me quedé con el seudocódigo que mis compañeros ya sabían usar. El estándar cierra con una ambición que hoy leo con cariño: "se espera que Ñ sea el lenguaje más popular entre los hispanohablantes".

Entre octubre y diciembre de 2014 programé el traductor —una clase `ÑL` con un método `toCS` que convierte cada línea de Ñ en C#— y un entorno para escribirlo, con ejemplos y reporte de errores.

Por esos días descubrí algo que cambió el alcance del proyecto: desde un programa en C# se puede invocar al compilador de C#. Con eso, la herramienta que llamaba Compiler dejó de ser una promesa, y Code Generator pudo compilar y ejecutar lo que generaba en lugar de solo mostrarlo.

## Abeona Suite: la web (2015)

De cara al concurso de 2015, mi asesora insistió en que sumara a alguien al equipo. Me resistí: sentía que el proyecto era mío y no quería repartir el mérito. Cedí, y acerté. Carlos Conchas se integró y formamos una dupla que funcionaba de verdad: él optimizó programas que yo daba por terminados y le dio al editor de Ñ y de C# el coloreado de sintaxis que lo hizo parecer, por fin, un entorno profesional. La última etapa de Abeona no existiría sin él. También me bajó de una nube: hasta entonces me creía el mejor programador de la escuela; después de trabajar con Carlos, un año menor que yo, me quedé con el título solo dentro de mi generación.

Con él dio el proyecto el salto que anunciaba la ficha técnica: del escritorio a la web. **Abeona Suite**, en ASP.NET, reunía siete herramientas —Code Generator para C# y VB, Compiler, Diagram Generator, Desk Tester, App Designer, Web Designer y un editor de texto— con cuentas de usuario y archivos guardados por cuenta. Tres años separaban esa página, capaz de compilar Ñ y entregar el ejecutable, de la consola de 2013.

La razón por la que me parecía tan importante era muy concreta: muchos compañeros no tenían computadora, pero sí celular. Con la suite en línea podían hacer la tarea desde el teléfono y descargar el ejecutable y el código fuente que les pedían para entregarla. El guion que preparamos para el jurado lo decía en una frase: no necesita instalarse, es independiente del sistema operativo y se usa desde un móvil o una computadora. Los planes iban más lejos: integrarla con una plataforma de e-learning, mantenerla en un servidor disponible las 24 horas y, algún día, fundar una empresa.

El nombre ya era el de la suite completa. Abeona es la diosa romana que cuidaba a los niños en sus primeros pasos fuera de casa; el proyecto quería cuidar los primeros pasos de quien aprende a programar. Con esa suite llegamos a la etapa nacional del concurso en 2015.

## El final (2016)

En 2016 el proyecto ya tenía marca por tercera vez: empezó como Selene Software, pasó a SeleneSoft y terminó bajo IntelINay. De ese año son el sitio de SeleneSoft y el Compilador Ñ 3.0, un entorno en WPF para la versión 2.5 del lenguaje, que compilaba a ejecutable y traducía los errores al español. Ñ 2.5 ya tenía manual propio y una sintaxis distinta a la del estándar de 2014:

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

Después de 2016 no volví a intentar terminarlo en serio. El último archivo es de enero de 2017: el esqueleto vacío de un nuevo Ñ, con un comentario que muestra hacia dónde iba el lenguaje, ya orientado a objetos. La idea, que nunca llegó a ningún documento, era que Ñ corriera en cualquier máquina, como Java, pero sin pasar por un bytecode: que compilara directamente a código nativo de cada plataforma.

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

Ahí se quedó. Con el tiempo se perdió el dominio selenesoft.net, y con él los enlaces que aparecen en el manual y en los programas.

## Lo que hay en este archivo

- El código de Code Generator (2013 y 2014), Diagram Generator (2013 y 2014), el traductor y el IDE de Ñ (2014), el despliegue de Abeona Suite (2015), el sitio de SeleneSoft y el Compilador Ñ 3.0 (2016).
- Las capturas de las nueve versiones de 2013, las notas de versión, la encuesta de 2014 y los documentos: el Estándar de Ñ, el manual de Ñ 2.5, las fichas técnicas, el guion del concurso y el manual de usuario de Code Generator.
- Todo está como estaba, con una excepción: en los documentos y las páginas reemplacé los correos y teléfonos por marcas de censura, y la base de datos de la suite se publica vacía porque la original guardaba cuentas reales.

El detalle de cada carpeta, cómo compilar cada programa, cómo activar Code Generator sin licencia y las tablas de comandos de Ñ están en [`docs/referencia.md`](docs/referencia.md).

## Créditos

- **Néstor Rodríguez**: idea, diseño y desarrollo (2013–2016).
- **Carlos Conchas**: lenguaje Ñ, su compilador y Abeona Suite (2015–2016).
- **Daniela Delgado** e **Ismael López**: colaboración en Code Generator (2013).
- **Yissell Berenice Dueñas Aguirre**: asesora del concurso (2014–2015).

## Nota de 2026

Armé este archivo en 2026, más de diez años después, con lo que pude recuperar. Al ordenarlo apareció en una carpeta olvidada el traductor de Ñ de 2014, que daba por perdido. El código y los documentos están tal como eran entonces; lo único que cambié fueron los datos de contacto. La idea sigue viva: la nueva versión de Abeona se desarrolla en [**Abeona-Project**](https://github.com/nestorrguez/Abeona-Project).
