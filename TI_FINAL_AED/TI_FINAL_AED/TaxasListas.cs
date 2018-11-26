using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class TaxasListas
    {
        TaxasNo _sentinela, _ultimo, _primeiro;
        internal TaxasNo primeiro
        {
            get { return _primeiro; }
            set { _primeiro = value; }
        }

        internal TaxasNo ultimo
        {
            get { return _ultimo; }
            set { _ultimo = value; }
        }

        internal TaxasNo sentinela
        {
            get { return _sentinela; }
            set { _sentinela = value; }
        }

        public TaxasListas()
        {
            sentinela = new TaxasNo();
            ultimo = sentinela;
            primeiro = sentinela;
        }

        internal bool verificaDataPagamento()
        {
            Taxas aux = procurar(DateTime.Now.Year);
            if (aux != null)
            {
                return true;
            }

            aux = procurar(DateTime.Now.Year -1);
            if (aux != null)
            {
                return true;
            }

            aux = procurar(DateTime.Now.Year - 2);
            if (aux != null)
            {
                return true;
            }

            aux = procurar(DateTime.Now.Year - 3);
            if (aux != null)
            {
                return true;
            }

            return false;
        }

        public void inserir(Taxas novo)
        {
            TaxasNo NovoNode = new TaxasNo(novo);
            ultimo.prox = NovoNode;
            ultimo = NovoNode;
        }

        public Taxas procurar(int ano)
        {
            TaxasNo aux = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.taxa.anoPagamento.Equals(ano))
                {
                    return aux.taxa;
                }
            }
            return null;
        }

        public Taxas procurarIndex(int index)
        {
            TaxasNo aux = sentinela;
            int cont = -1;
            while (aux.prox != null)
            {
                aux = aux.prox;
                cont++;
                if (cont == index)
                {
                    return aux.taxa;
                }
            }
            return null;
        }

        public bool vazia()
        {
            return ultimo == primeiro;
        }

        public bool jaInserido(Taxas veiculo)
        {
            TaxasNo aux = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.taxa.anoPagamento.Equals(veiculo.anoPagamento))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
