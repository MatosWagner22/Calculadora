using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class ClassOp
    {
        public double Sumar(double N1, double N2)
        {
            double S;
            S = N1 + N2;
            return S;
        }

        public double Restar(double N1, double N2)
        {
            double R;
            R = N1 - N2;
            return R;
        }

        public double Multiplicacion(double N1, double N2)
        {
            double M;
            M = N1 * N2;
            return M;
        }

        public double Dividir(double N1, double N2)
        {
            double D;
            D = N1 / N2;
            return D;
        }
    }
}
