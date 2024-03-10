using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm.Models
{
    internal class SumaModel
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }

        internal double Sumar()
        {
            return Valor1 + Valor2;
        }
    }
}
