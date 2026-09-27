using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    // Herencia
    internal class Directivos : Empleado
    {
        // Encapsulamiento
        public float Bono { get; set; }

        public Directivos(string nombre, string dni, float sueldobase, float bono) : base(nombre, dni, sueldobase)
        {
            Bono = bono;
        }

        // Polimorfismo
        public override float PagoFinal()
        {
            return SueldoBase + Bono;
        }
    }
}