using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Taxas
    {
        public int anoPagamento;

        public Taxas(int anoTaxas)
        {
            this.anoPagamento = anoTaxas;
        }

        /*Validando se a data de pagamento da taxa é menor que 3 anos*/
        public bool verificaDataPagamento()
        {
            if (anoPagamento < DateTime.Now.AddYears(-3).Year)
            {
                return false;
            }
            return true;
        }

    }
}
