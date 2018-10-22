using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_with_SO
{
    class Nodo
    {
        public Processo dadoProcesso;
        public Nodo anterior, seguinte;
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
            Nodo inserirPrimeiroNodo = new Nodo();
            inserirPrimeiroNodo.dadoProcesso = x;
            if (raiz == null)
            {
                inserirPrimeiroNodo.seguinte = inserirPrimeiroNodo;
                inserirPrimeiroNodo.anterior = inserirPrimeiroNodo;
                raiz = inserirPrimeiroNodo;
            }
            else
            {
                Nodo ultimo = raiz.anterior;
                inserirPrimeiroNodo.seguinte = raiz;
                inserirPrimeiroNodo.anterior = ultimo;
                raiz.anterior = inserirPrimeiroNodo;
                ultimo.seguinte = inserirPrimeiroNodo;
                raiz = inserirPrimeiroNodo;
            }
        }

        public void InserirUltimo(Processo x)
        {
            Nodo inserirUltimoNodo = new Nodo();
            inserirUltimoNodo.dadoProcesso = x;
            if (raiz == null)
            {
                inserirUltimoNodo.seguinte = inserirUltimoNodo;
                inserirUltimoNodo.anterior = inserirUltimoNodo;
                raiz = inserirUltimoNodo;
            }
            else
            {
                Nodo ultimo = raiz.anterior;
                inserirUltimoNodo.seguinte = raiz;
                inserirUltimoNodo.anterior = ultimo;
                raiz.anterior = inserirUltimoNodo;
                ultimo.seguinte = inserirUltimoNodo;
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
                    Console.Write(aux.dadoProcesso + "-");
                    aux = aux.seguinte;
                } while (aux != raiz);
                Console.WriteLine();
            }
        }

        public int Count()
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
                        Nodo ultimo = raiz.anterior;
                        raiz = raiz.seguinte;
                        ultimo.seguinte = raiz;
                        raiz.anterior = ultimo;
                    }
                }
                else
                {
                    Nodo aux = raiz;
                    for (int f = 1; f <= pos - 1; f++)
                        aux = aux.seguinte;
                    Nodo anterior = aux.anterior;
                    aux = aux.seguinte;
                    anterior.seguinte = aux;
                    aux.anterior = anterior;
                }
            }
        }
        
    }
}