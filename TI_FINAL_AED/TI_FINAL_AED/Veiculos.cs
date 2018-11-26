using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Veiculos
    {
        public TaxasListas IPVA;
        public TaxasListas seguroObrigatorio;
        public TaxasListas Licenciamento;
        public string placa;
        public MultasListas listaMultasPorVeiculo;

        public Veiculos(string placa)
        {
            this.placa = placa;
            listaMultasPorVeiculo = new MultasListas();
            IPVA = new TaxasListas();
            Licenciamento = new TaxasListas();
            seguroObrigatorio = new TaxasListas();
        }

        /*Se ao menos um documento retornar false, o veículo está irregular*/
        public bool verificaRegularidadeVeiculo()
        {
            if (!IPVA.verificaDataPagamento()
                || !seguroObrigatorio.verificaDataPagamento()
                || !Licenciamento.verificaDataPagamento())
            {
                return false;
            }
            return true;
        }

        internal void inserirTaxa(string taxa, int ano)
        {

            switch (taxa)
            {
                case "1":
                    IPVA.inserir(new Taxas(ano));
                    break;
                case "2":
                    seguroObrigatorio.inserir(new Taxas(ano));
                    break;
                case "3":
                    Licenciamento.inserir(new Taxas(ano));
                    break;
                default:
                    break;
            }

        }
    }
}
