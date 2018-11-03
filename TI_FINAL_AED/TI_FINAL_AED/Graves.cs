using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Graves : Multas
    {
        public Graves(DateTime dataEmissao, Veiculos veiculo, Condutores condutor)
        {
            this.pontuacaoMulta = 7;
            this.valorMulta = 500.00;
            this.dataEmissao = dataEmissao;
            this.veiculo = veiculo;
            this.condutor = condutor;
        }
    }
}
