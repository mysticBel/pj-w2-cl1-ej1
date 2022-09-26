using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_CL1_MaribelMaza
{
    internal class Prestamo_Semestral: Prestamo
    {
        public override double determinarPorcInteres()
        {

            switch (letras)
            {
                case "3": return 0.5;
                case "6": return 1.0;
                case "9": return 1.3;
                case "12": return 1.5;
            }
            return 0;
        }
    }
}
