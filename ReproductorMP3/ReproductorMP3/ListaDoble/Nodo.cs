using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMP3.ListaDoble
{
    public class Nodo
    {
        public String dato;//Cambie tipo de dato a String
        public Nodo adelante;
        public Nodo atras;

        public String getDato()//Cambie tipo de dato a String
        {
            return dato;
        }
        public Nodo(String entrada)//Cambie de dato a String
        {
            dato = entrada;
            adelante = atras = null;
        }
    }
}
