using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            Vendedores vendedor = new Vendedores("pepe", "49123456", 500000, 50000);

            Directivos directivo = new Directivos("juan", "30123456", 700000, 100000);


            empleados.Add(vendedor);

            empleados.Add(directivo);


            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine(empleado.Nombre);
                Console.WriteLine(empleado.PagoFinal());
            }
        }
        

    }
}
