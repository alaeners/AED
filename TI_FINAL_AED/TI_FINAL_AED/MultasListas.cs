using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class MultasListas
    {
        MultasNo _sentinela, _primeiro, _ultimo;

        public MultasNo ultimo
        {
            get { return _ultimo; }
            set { _ultimo = value; }
        }

        public MultasNo primeiro
        {
            get { return _primeiro; }
            set { _primeiro = value; }
        }

        public MultasNo sentinela
        {
            get { return _sentinela; }
            set { _sentinela = value; }
        }

        public MultasListas()
        {
            _sentinela = new MultasNo();
            primeiro = sentinela;
            ultimo = sentinela;
        }

        public void inserir(Multas info)
        {
            MultasNo novo = new MultasNo(info);
            MultasNo auxiliar = _sentinela;
            MultasNo auxiliar2 = _sentinela;

            if (primeiro == ultimo)
            {
                sentinela.prox = novo;
                ultimo = novo;
            }
            else
            {
                while (auxiliar.prox != null)
                {
                    auxiliar = auxiliar.prox;

                    if (auxiliar.multa.dataEmissao > novo.multa.dataEmissao)
                    {
                        auxiliar2.prox = novo;
                        novo.prox = auxiliar;
                        return;
                    }
                    else if (auxiliar == ultimo)
                    {
                        ultimo.prox = novo;
                        ultimo = novo;
                        return;
                    }
                    auxiliar2 = auxiliar2.prox;
                }
            }


        }

        public Multas Buscar(string placa, long CNH, DateTime data)
        {
            MultasNo aux = sentinela;
            while (aux.prox != null)
            {
                aux = aux.prox;
                if (aux.multa.veiculo.placa == placa 
                    && aux.multa.condutor.habilitacaoCondutor.cnh == CNH.ToString() 
                    && aux.multa.dataEmissao == data)
                {
                    return aux.multa;
                }
            }
            return null;
        }

        //ele percorre a lista e quando acha uma multa que tem menos de 1 anos realiza a soma da pontuacao
        public int verificaPontuacaoMultas()
        {
            int pontuacao = 0;
            MultasNo auxiliar = _sentinela;
            DateTime dataReferencia = DateTime.Now.AddYears(-1);

            while (auxiliar.prox != null)
            {
                auxiliar = auxiliar.prox;
                if (auxiliar.multa.dataEmissao > dataReferencia)
                {
                    pontuacao += auxiliar.multa.pontuacaoMulta;

                }
            }
            return pontuacao;
        }

        //verifica a soma de valor das multas
        public double verificaValoresMultas()
        {
            double valor = 0.0;
            MultasNo auxiliar = _sentinela;
            DateTime dataReferencia = DateTime.Now.AddYears(-1);

            while (auxiliar.prox != null)
            {
                auxiliar = auxiliar.prox;
                if (auxiliar.multa.dataEmissao > dataReferencia)
                {
                    valor += auxiliar.multa.valorMulta;

                }
            }
            return valor;
        }

        public VeiculosListas GetVeiculosComMultas()
        {
            VeiculosListas veiculosComMultas = new VeiculosListas();
            MultasNo auxiliar = _sentinela;

            while (auxiliar.prox != null)
            {
                auxiliar = auxiliar.prox;
                if (!veiculosComMultas.jaInserido(auxiliar.multa.veiculo))
                {
                    veiculosComMultas.inserir(auxiliar.multa.veiculo);
                }                
            }
            return veiculosComMultas;
        }

        public bool vazia()
        {
            return primeiro == ultimo;
        }
    }
}
