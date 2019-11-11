using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_Poo.clases
{
    public class gasolina
    {
        private string tipo;
        private double cantidadDeGalones;
        private double precioDeVenta;

        private double subtotal;
        private double iva;
        private double total;

        public string Tipo
        {
            get {
                return tipo;
                }
            set { tipo = value; }
        }

        public double CantidadDeGalones
        {
            get { return cantidadDeGalones; }
            set { cantidadDeGalones = value; }
        }

        public double PrecioDeVenta
        {
            get
            {
                if (Tipo == "super")
                {
                    precioDeVenta = 2.00;
                }
                else if (Tipo == "extra")
                {
                    precioDeVenta = 1.50;
                }
                return precioDeVenta;
            }
        }

        public double SubTotal
        {
            get {
                subtotal = precioDeVenta * cantidadDeGalones;
                return subtotal;
                }
        }

        public double Iva
        {
            get {
                iva = (subtotal * 12) / 100;
                return iva; 
                }
        }

        public double Total
        {
            get { 
                total = SubTotal + Iva;
                return total;
                }
        }
    }
}
