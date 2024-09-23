using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_I.models
{
    internal class Operacion
    {
        public int CalcularEdad(Persona persona)
        {
            int edad = DateTime.Now.Year - persona.FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < persona.FechaNacimiento.DayOfYear)
            {
                edad--;
            }
            return edad;
        }

        public string EsMayorDeEdad(Persona persona)
        {
            int edad = CalcularEdad(persona);
            if (edad >= 18)
            {
                return "Mayor de edad";
            }
            else
            {
                return "Menor de edad";
            }
        }
    }
}
