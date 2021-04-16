using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMP3.ListaDoble
{
   class clsListaDoble
    {
        public Nodo cabeza; // Es el nodo que se llama primero
        public Nodo nuevo;
        private int tamaño;
        public clsListaDoble()
        {
            cabeza = null;
        }
        public clsListaDoble insertarCabezaLista(String entrada)//Cambie tipo de dato a String
        {

            //Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;

            return null;
        }

        public clsListaDoble insertaDespues(Nodo anterior, String entrada)//Cambie tipo de dato a String
        {
            //Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = anterior.adelante;
            if (anterior.adelante != null)
            {


                anterior.adelante.atras = nuevo;
            }
            anterior.adelante = nuevo;
            nuevo.atras = anterior;
            return this;

        }

        public void elimminar(String entrada)//Cambie tipo de dato a String
        {
            Nodo actual;
            actual = cabeza;
            bool encontrado = false;
            //bucle de busqueda

            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato.Equals(entrada));//Hago Comparacion con Equals
                if (!encontrado)
                {
                    actual = actual.adelante;
                }
            }//fin While
             //enlace de nodo anterior con el siguiente

            if (actual != null)
            {
                //Distinguir entre nodo cabecera del resto de la lista
                if (actual.Equals(cabeza))
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                    else if (actual.adelante != null)//No es el ultimo nodo
                    {
                        actual.atras.adelante = actual.adelante;
                        actual.adelante.atras = actual.atras;
                    }
                    else //Es el ultimo nodo
                    {
                        actual.atras.adelante = null;

                    }
                    actual = null;
                }
            }//Fin de If
        }
        public void transversa() {
            Nodo n = cabeza;
            string dt;
            

            while (n != null) {
                dt = n.dato;
                n = n.adelante;
                this.tamaño = this.tamaño + 1;//Obtenemos el tamaño de la Lista
            }
        }



        public String[] visualizar()
        {
            transversa();
            string[] datos = new string [this.tamaño];
            Nodo n;
            n = cabeza;
            int cont = 0;

            while (n != null)
            {
                string dt;
                dt = n.dato;
                datos[cont] = dt;
                n = n.adelante;
                cont++;
            }
            return datos;
        }




        //public String[] vizualizar() { 
        //    string[] datos= new string(this.)

        //}


    }
}
