using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_CL1_MaribelMaza
{
    internal class Prestamo
    {
        public string nombreCliente { get; set; }
        public string numCuenta { get; set; } 
        public int montoPrestado { get; set; }
        public string letras { get; set; }
        
        
        //Constructor
        public Prestamo() { 
            this.letras = "3";
        }

        //Metodo para determinar porcentaje de interés
        public virtual double determinarPorcInteres()
        {

            switch (letras)
            {
                case "3": return 1.2;
                case "6": return 1.5;
                case "9": return 1.8;
                case "12": return 2.5;
            }
            return 0;
        }

        // Método para calcular el monto de interés segun letra ingresada
        public double calcularTotalInteres()
        {
            return montoPrestado * determinarPorcInteres()/100;
        }
        //Metodo para calcular monto mensual
        public double calcularMontoMensual()
        {
            return ((montoPrestado + calcularTotalInteres() )/ int.Parse(letras));
        }
    }
}
