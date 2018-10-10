using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SimonBase.SimonForm;
using SimonBase;

namespace AED_SimonTest
{
    class Queue
    {

        public Item frente; // referência ao item que está na frente da fila. Esse item é utilizado apenas para controle.
        public Item tras;   // referência ao item que está na última posição da fila.

        internal int Count()
        {
            int cont = 1;
            Item aux = frente;
            while (aux.next != null)
            {
                aux = aux.next;
                cont++;
            }
            return cont;
        }

        // Construtor que cria uma fila vazia inicializando o item da frente da fila e os atributos de controle da fila (frente e tras).
        public Queue(Botao color)
        {
            Item el;

            el = new Item(color);
            frente = el;
            tras = el;
        }

        public Queue()
        {

        }

        // Verifica se a fila está vazia. Em caso afirmativo, retorna true e em caso negativo retorna false.
        public Boolean EmptyQueue()
        {
            // se a fila apresentar apenas o item de controle, ela está vazia.
            if (frente == tras)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void Clear()
        {
            throw new NotImplementedException();
        }

        // Insere o item el, passado como parâmetro para esse método, no final da fila.
        public void Enqueue(Botao el)
        {

            Item novo = new Item(el);
            // inserção do novo item no final da fila.
            tras.next = novo;

            // atualização do atributo de controle tras.
            tras = novo;
        }

        internal void clickBotoes()
        {
            
        }

        /// Retira o item que ocupa a primeira posição da fila. 
        /// Se a fila estiver vazia, esse método retorna null; caso contrário, esse método retorna o item retirado da fila.
        public Botao Dequeue()
        {
            // el aponta para o item da fila que será retornado/desenfileirado, ou seja, o primeiro item da fila.
            Item el = frente.next;

            if (!(EmptyQueue()))
            {
                // atualização do primeiro item da fila.
                frente.next = el.next;

                el.next = null;
            }
            return (el.botao);
        }
    }
}
