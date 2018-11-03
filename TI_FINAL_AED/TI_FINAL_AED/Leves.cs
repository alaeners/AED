using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Leves : Multas
    {
        public Leves(DateTime dataEmissao, Veiculos veiculo, Condutores condutor)
        {
            this.pontuacaoMulta = 3;
            this.valorMulta = 125.00;
            this.dataEmissao = dataEmissao;
            this.veiculo = veiculo;
            this.condutor = condutor;
        }
    }
}
