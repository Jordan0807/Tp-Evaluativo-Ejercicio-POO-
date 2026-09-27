namespace EjercicioPOO
{
    internal class Empleado
    {
        // Encapsulamiento
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public float SueldoBase { get; set; }

        public Empleado(string nombre, string dni, float sueldoBase)
        {
            Nombre = nombre;
            Dni = dni;
            SueldoBase = sueldoBase;
        }

        // Polimorfismo
        public virtual float PagoFinal()
        {
            return SueldoBase;
        }
    }
}