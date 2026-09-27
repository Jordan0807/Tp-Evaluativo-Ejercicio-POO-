using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{

    // Herencia
    internal class Vendedores : Empleado
    {
        // Encapsulamiento
        public float Comision { get; set; }

        public Vendedores(string nombre, string dni, float sueldobase, float comision) : base(nombre, dni, sueldobase)
        {
            Comision = comision;
        }

        // Polimorfismo
        public override float PagoFinal()
        {
            return SueldoBase + Comision;
        }
    }
}