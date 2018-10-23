using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador
{
    class ListaCircular
    {
        private Nodo raiz;

        public ListaCircular()
        {
            raiz = null;
        }

        public void InserirPrimeiro(Processo x)
        {
            Nodo NovoNodo = new Nodo();
            NovoNodo.dado = x;
            if (raiz == null)
            {
                NovoNodo.seguinte = NovoNodo;
                NovoNodo.anterior = NovoNodo;
                raiz = NovoNodo;
            }
            else
            {
                Nodo ultimo = raiz.anterior;
                NovoNodo.seguinte = raiz;
                NovoNodo.anterior = ultimo;
                raiz.anterior = NovoNodo;
                ultimo.seguinte = NovoNodo;
                raiz = NovoNodo;
            }
        }

        public void InserirUltimo(Processo x)
        {
            Nodo NovoNodo = new Nodo();
            NovoNodo.dado = x;
            if (raiz == null)
            {
                NovoNodo.seguinte = NovoNodo;
                NovoNodo.anterior = NovoNodo;
                raiz = NovoNodo;
            }
            else
            {
                Nodo ultimo = raiz.anterior;
                NovoNodo.seguinte = raiz;
                NovoNodo.anterior = ultimo;
                raiz.anterior = NovoNodo;
                ultimo.seguinte = NovoNodo;
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
                Nodo aux = raiz;
                do
                {
                    Console.Write(aux.dado + "-");
                    aux = aux.seguinte;
                } while (aux != raiz);
                Console.WriteLine();
            }
        }

        public int Contar()
        {
            int cont = 0;
            if (!Vazia())
            {
                Nodo aux = raiz;
                do
                {
                    cont++;
                    aux = aux.seguinte;
                } while (aux != raiz);
            }
            return cont;
        }

        public Processo Remover(int pos)
        {
            if (pos <= Contar())
            {
                if (pos == 1)
                {
                    if (Contar() == 1)
                    {
                        Processo aux = raiz.dado;
                        raiz = null;
                        return aux;
                    }
                    else
                    {
                        Processo aux = raiz.dado;
                        Nodo ultimo = raiz.anterior;
                        raiz = raiz.seguinte;
                        ultimo.seguinte = raiz;
                        raiz.anterior = ultimo;
                        return aux;
                    }
                }
                else
                {
                    Nodo aux = raiz;
                    for (int f = 1; f <= pos - 1; f++)
                        aux = aux.seguinte;
                    Processo auxp = aux.dado;
                    Nodo anterior = aux.anterior;
                    aux = aux.seguinte;
                    anterior.seguinte = aux;
                    aux.anterior = anterior;
                    return auxp;
                }
            }
            return null;

        }
    }
}
