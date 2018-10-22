using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_with_SO
{
    class Nodo
    {
        public Processo info;
        public Nodo ant, sig;
    }
    public class ListaCircular
    {
        private Nodo raiz;
        
        public ListaCircular()
        {
            raiz = null;
        }

        public void InserirPrimero(Processo x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz = nuevo;
            }
            else
            {
                Nodo ultimo = raiz.ant;
                nuevo.sig = raiz;
                nuevo.ant = ultimo;
                raiz.ant = nuevo;
                ultimo.sig = nuevo;
                raiz = nuevo;
            }
        }

        public void InserirUltimo(Processo x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz = nuevo;
            }
            else
            {
                Nodo ultimo = raiz.ant;
                nuevo.sig = raiz;
                nuevo.ant = ultimo;
                raiz.ant = nuevo;
                ultimo.sig = nuevo;
            }
        }

        public bool Vazia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            if (!Vazia())
            {
                Nodo reco = raiz;
                do
                {
                    Console.Write(reco.info + "-");
                    reco = reco.sig;
                } while (reco != raiz);
                Console.WriteLine();
            }
        }

        public int Count()
        {
            int cant = 0;
            if (!Vazia())
            {
                Nodo reco = raiz;
                do
                {
                    cant++;
                    reco = reco.sig;
                } while (reco != raiz);
            }
            return cant;
        }

        public void Remover(int pos)
        {
            if (pos <= Count())
            {
                if (pos == 1)
                {
                    if (Count() == 1)
                    {
                        raiz = null;
                    }
                    else
                    {
                        Nodo ultimo = raiz.ant;
                        raiz = raiz.sig;
                        ultimo.sig = raiz;
                        raiz.ant = ultimo;
                    }
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 1; f++)
                        reco = reco.sig;
                    Nodo anterior = reco.ant;
                    reco = reco.sig;
                    anterior.sig = reco;
                    reco.ant = anterior;
                }
            }
        }
        
    }
}

