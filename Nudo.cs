using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenErk
{
    public class Nudo
    {

        private string nombre ;
        private int edad;
        private Nudo siguiente;



        public string Nombre
        {
            get{ return nombre; }
            set{ nombre = value; }
        }
        public int Edad
        {
            get { return edad; } 
            set { edad = value; }
        }
        public Nudo Siguiente 
        {
            get { return siguiente;}
            set { siguiente = value; }
        
        }


    }

    //public string Nombre()
    //{
    //    get{ return nombre; }
    //    set{ }
    //}
}
