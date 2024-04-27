using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02A
{
    internal class GestorRecursosHumanos
    {

        public void CalcularPagos(ITipoEmpleado tipoEmpleado, int horasTrabajadas)
        {
            tipoEmpleado.CalcularSueldo(horasTrabajadas);
            tipoEmpleado.CalcularBonificacion(horasTrabajadas);
        }
    }
}
