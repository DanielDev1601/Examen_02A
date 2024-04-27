using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02A
{
    internal interface ITipoEmpleado
    {

        void CalcularSueldo(int horasTrabajadas);

        void CalcularBonificacion(int horasTrabajadas);

    }
}
