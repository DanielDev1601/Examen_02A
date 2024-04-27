using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02A
{
    internal class EmpleadoTiempoCompleto : ITipoEmpleado
    {
        public string? nombre { get; set; }
        public double precioPorHora { get; set; }

        public void CalcularBonificacion(int horasTrabajadas)
        {
            Console.WriteLine($"Bonificación de {nombre}  : { (precioPorHora * horasTrabajadas) * 0.05 }");
        }

        public void CalcularSueldo(int horasTrabajadas)
        {
            Console.WriteLine($"Sueldo de {nombre} : {precioPorHora * horasTrabajadas}");           
        }

    }
}
