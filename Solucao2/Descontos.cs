using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace SolucaoDesc
{
    public class Descontos {
        public float CalcularDesconto(float valorunit, float desconto)
        {
            float descontoDecimal = desconto / 100;

            float descontoCalc = valorunit *  descontoDecimal;

            return valorunit - descontoCalc;
        }
    }
}