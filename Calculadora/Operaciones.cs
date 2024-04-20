using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    internal class Operaciones
    {
        public bool Numerico (string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }catch (Exception)
            {

                return false;
            }

        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }
    }
}
