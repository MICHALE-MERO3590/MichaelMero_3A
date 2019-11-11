using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_Poo.clases
{
    public class cliente
    {
        private string nombre;
        private string apellidos;
        private string id;
        private string direccion;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Id
        {
            get{ return id ;}
            set {id = value;}
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
