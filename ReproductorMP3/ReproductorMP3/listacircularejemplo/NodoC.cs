using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMP3.listacircularejemplo
{
   public  class NodoC
    {
        public String dato;
        public NodoC enlace;

        public NodoC(String entrada)
        {
            dato = entrada;
            enlace = this; // se apunta asímismo

        }
    }
}
