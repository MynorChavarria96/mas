using PruebaListasString.ListaString;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaListasString.objListaOrdenada
{
     class ListaOrdenada :Lista
    {

        public ListaOrdenada()

             : base()
        {

        }

        //public ListaOrdenada insertaOrden(string entrada)
        //{
        //    Nodo nuevo;
        //    nuevo = new Nodo(entrada);
        //    if (primero == null)
        //    {
        //        primero = nuevo;

        //    }
        //    else if (entrada.CompareTo(primero.getDatos()) < 0)
        //    {
        //        nuevo.setEnlcae(primero);
        //        primero = nuevo;

        //    }
        //    else
        //    {
        //        Nodo anterior, p;
        //        anterior = p = primero;
        //        while ((p.getEnlace() != null) && (entrada.CompareTo(p.getDatos()) > 0))
        //        {
        //            anterior = p;
        //            p = p.getEnlace();

        //        }
        //        if (entrada.CompareTo(p.getDatos()) > 0)
        //        {
        //            anterior = p;
        //        }
        //        nuevo.setEnlcae(anterior.getEnlace());
        //        anterior.setEnlcae(nuevo);
        //    }
        //    return this;
        //}

        public Nodo busca(int index)
        {
            int i = 0;
            Nodo auxiliar = primero;
            if (index < 0)
            {
                return null;
            }
            while (i != index)
            {
                auxiliar = auxiliar.enlace;
                i++;
            }
            return auxiliar;

        }

        public void eliminar(int principal)
        {

            Nodo ahora, antes;
            bool encontrado;
            Nodo dato = busca(principal);
            ahora = primero;
            antes = null;
            encontrado = false;

            while ((ahora != null) && (!encontrado))
            {
                encontrado = (ahora.enlace == dato.enlace);

                if (!encontrado)
                {
                    antes = ahora;
                    ahora = ahora.enlace;
                }
            }

            //Enlace del Nodo anterior con el siguiente
            if (ahora != null)
            {
                if (ahora == primero)
                {
                    primero = ahora.enlace;
                }
                else
                {
                    antes.enlace = ahora.enlace;
                }
            }
        }

        public void visualizar()
        {
            Nodo n;
            int k = 0;
            n = primero;
            while (n != null)
            {
                Console.WriteLine(n.dato + " ");
                n = n.enlace;
                k++;
                Console.WriteLine((k % 15 != 0 ? "" : "\n"));
            }




        }








    }

}
