using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_de_Luz
{
    class Calculo_Conta
    {
        public float resumof;
        public float Calculo(float luz, float km, float total)
        {
            total = luz * km;
            return total;
        }
    }
   
}

