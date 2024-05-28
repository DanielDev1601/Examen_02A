// See https://aka.ms/new-console-template for more information

using Examen02A;

ITipoEmpleado empleadoPorProyecto = new EmpleadoPorProyecto { nombre = "Daniel",precioPorHora = 15 };
ITipoEmpleado empleadoTiempoCompleto = new EmpleadoTiempoCompleto { nombre = "Jose", precioPorHora = 25 };

GestorRecursosHumanos gestorRecursosHumanos = new GestorRecursosHumanos();

Console.WriteLine($"Calculo de Pagos");
Console.WriteLine("==========================================");
Console.WriteLine("Empleado por proyecto");
gestorRecursosHumanos.CalcularPagos(empleadoPorProyecto, 10);
Console.WriteLine();
Console.WriteLine("Empleado tiempo completo");
gestorRecursosHumanos.CalcularPagos(empleadoTiempoCompleto, 15);
Console.WriteLine("==========================================");
Console.ReadLine();

//mi primer comentario
