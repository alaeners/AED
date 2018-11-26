using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class CondutoresListas
    {
        CondutoresNo _sentinela, _ultimo, _primeiro;
        public int colisao = 0;
        internal CondutoresNo primeiro
        {
            get { return _primeiro; }
            set { _primeiro = value; }
        }

        internal CondutoresNo ultimo
        {
            get { return _ultimo; }
            set { _ultimo = value; }
        }

        internal CondutoresNo sentinela
        {
            get { return _sentinela; }
            set { _sentinela = value; }
        }

        public CondutoresListas()
        {
            sentinela = new CondutoresNo();
            ultimo = sentinela;
            primeiro = sentinela;
        }

        public void inserir(Condutores novo)
        {
            if (!vazia())
            {
                colisao++;
            }
            CondutoresNo NovoNode = new CondutoresNo(novo);
            ultimo.prox = NovoNode;
            ultimo = NovoNode;
        }

        public Condutores retirar(string habilitacao)
        {
            CondutoresNo aux = sentinela;
            CondutoresNo aux2 = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.condutor.habilitacaoCondutor.cnh.Equals(habilitacao.ToString()))
                {
                    aux2.prox = aux.prox;
                    aux.prox = null;
                    return aux.condutor;
                }
                aux2 = aux2.prox;
            }
            return null;
        }
        public Condutores procurar(string habilitacao)
        {
            CondutoresNo aux = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.condutor.habilitacaoCondutor.cnh.Equals(habilitacao))
                {
                    return aux.condutor;
                }
            }
            return null;
        }

        public Condutores procurarIndex(int index)
        {
            CondutoresNo aux = sentinela;
            int cont = -1;
            while (aux.prox != null)
            {
                aux = aux.prox;
                cont++;
                if (cont == index)
                {
                    return aux.condutor;
                }
            }
            return null;
        }

        public bool vazia()
        {
            return ultimo == primeiro;
        }
    }
}
