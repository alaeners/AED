using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class VeiculosListas
    {
        VeiculosNo _sentinela, _ultimo, _primeiro;
        public int colisao;
        internal VeiculosNo primeiro
        {
            get { return _primeiro; }
            set { _primeiro = value; }
        }

        internal VeiculosNo ultimo
        {
            get { return _ultimo; }
            set { _ultimo = value; }
        }

        internal VeiculosNo sentinela
        {
            get { return _sentinela; }
            set { _sentinela = value; }
        }

        public VeiculosListas()
        {
            sentinela = new VeiculosNo();
            ultimo = sentinela;
            primeiro = sentinela;
            colisao = 0;
        }

        public void inserir(Veiculos novo)
        {
            if (!vazia())
            {
                colisao++;
            }


            VeiculosNo NovoNode = new VeiculosNo(novo);
            ultimo.prox = NovoNode;
            ultimo = NovoNode;
        }

        public Veiculos retirar(string placa)
        {
            VeiculosNo aux = sentinela;
            VeiculosNo aux2 = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.veiculo.placa.Equals(placa))
                {
                    aux2.prox = aux.prox;
                    aux.prox = null;
                    return aux.veiculo;
                }
                aux2 = aux2.prox;
            }
            return null;
        }
        public Veiculos procurar(string placa)
        {
            VeiculosNo aux = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.veiculo.placa.Equals(placa))
                {
                    return aux.veiculo;
                }
            }
            return null;
        }

        public Veiculos procurarIndex(int index)
        {
            VeiculosNo aux = sentinela;
            int cont = -1;
            while (aux.prox != null)
            {
                aux = aux.prox;
                cont++;
                if (cont == index)
                {
                    return aux.veiculo;
                }
            }
            return null;
        }

        public bool vazia()
        {
            return ultimo == primeiro;
        }

        public bool jaInserido(Veiculos veiculo)
        {
            VeiculosNo aux = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.veiculo.placa.Equals(veiculo.placa))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
