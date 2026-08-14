# Taller 01 de POO - Clase Time

<p align="center">
  <img src="https://www.itm.edu.co/wp-content/uploads/formatos/logo-ITM.png" alt="Logo ITM" width="160">
</p>

## Datos del estudiante

**Estudiante:** Santiago Suarez Ramirez  
**Universidad:** ITM - Institucion Universitaria  
**Asignatura:** Programacion orientada a objetos  
**Tecnologia:** .NET 8 y C#

## Descripcion

Este proyecto desarrolla la clase `Time` solicitada en el taller de POO. La clase permite crear objetos de tiempo con horas, minutos, segundos y milisegundos, validando los rangos indicados en el enunciado y ejecutando operaciones basicas sobre esos valores.

El programa principal crea cinco objetos `Time`, muestra sus conversiones a milisegundos, segundos y minutos, suma cada hora con `t3`, verifica si al sumarse con `t4` se pasa al otro dia y finalmente prueba una hora invalida para mostrar la excepcion correspondiente.

## Especificacion tecnica

- `Time.cs`: contiene la clase principal del taller.
- `Program.cs`: contiene el `Main` con las pruebas solicitadas.
- `InvalidTimeException.cs`: excepcion personalizada para valores invalidos.
- `taller_time.csproj`: configuracion necesaria para compilar el proyecto con .NET.

## Clase Time

La clase `Time` trabaja con cuatro campos privados:

```csharp
private int _hour;
private int _minute;
private int _second;
private int _millisecond;
```

Incluye cinco constructores:

- `Time()`
- `Time(int hour)`
- `Time(int hour, int minute)`
- `Time(int hour, int minute, int second)`
- `Time(int hour, int minute, int second, int millisecond)`

Tambien incluye los metodos:

- `ValidHour`
- `ValidMinute`
- `ValidSecond`
- `ValidMillisecond`
- `ToMilliseconds`
- `ToSeconds`
- `ToMinutes`
- `IsOtherDay`
- `Add`
- `ToString`

## Reglas implementadas

- Horas validas: de `0` a `23`.
- Minutos validos: de `0` a `59`.
- Segundos validos: de `0` a `59`.
- Milisegundos validos: de `0` a `999`.
- Si un valor no es valido, se lanza `InvalidTimeException`.
- La salida de `ToString` se muestra en formato de 12 horas con `AM` o `PM`.
- `Add` normaliza la suma cuando el resultado supera las 24 horas.
- `IsOtherDay` retorna `true` cuando la suma pasa al siguiente dia.

## Ejecucion

Desde la carpeta principal del proyecto:

```powershell
dotnet run --project .\taller_time\taller_time.csproj
```

## Entrega

Repositorio Git: https://github.com/santy8151/Taller_Estructuradedatos_poo.git  
Video publico de YouTube:

## Trabajo academico

Este repositorio corresponde a una entrega academica del Taller 01 de POO. El objetivo es demostrar el uso de clases, constructores, validaciones, excepciones y metodos en C# siguiendo el enunciado propuesto.
