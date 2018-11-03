using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Veiculos
    {
        public Taxas IPVA;
        public Taxas seguroObrigatorio;
        public Taxas Licenciamento;
        public string placa;

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
    }
}
