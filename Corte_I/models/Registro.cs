using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_I.models
{
    internal class Registro
    {
        public Persona[] personas = new Persona[30];
        public int contador = 0;

        public void AgregarPersona(Persona persona)
        {
            if (contador < 30)
            {
                personas[contador] = persona;
                contador++;
            }
            else
            {
                throw new InvalidOperationException("El registro está lleno");
            }
        }

        public string MostrarPersonas()
        {
            string resultado = "";
            for (int i = 0; i < contador; i++)
            {
                resultado += $"{personas[i].Nombres} {personas[i].Apellidos}, Ciudad: {personas[i].Ciudad}, Fecha de Nacimiento: {personas[i].FechaNacimiento.ToShortDateString()}\n";
            }
            return resultado;
        }
    }
}
