using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Medias : Multas
    {
        public Medias(DateTime dataEmissao, Veiculos veiculo, Condutores condutor)
        {
            this.pontuacaoMulta = 5;
            this.valorMulta = 250.00;
            this.dataEmissao = dataEmissao;
            this.veiculo = veiculo;
            this.condutor = condutor;
        }

    }
}