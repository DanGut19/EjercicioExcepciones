using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    internal class Calcular : Operaciones
    {
        public double A { get; set; }
        public double B { get; set; }
        public override double Resta()
        {
            return A - B;
        }

        public override double Suma()
        {
            return A + B;
        }

        public override double Divicion()
        {
            return A / B;
        }

        public override double Multiplicacion()
        {
            return A * B;
        }
    }
}
