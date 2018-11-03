using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Taxas
    {
        public DateTime dataPagamento;

        public Taxas(DateTime dataTaxas)
        {
            this.dataPagamento = dataTaxas;
        }

        /*Validando se a data de pagamento da taxa é menor que 3 anos*/
        public bool verificaDataPagamento()
        {
            if (dataPagamento < DateTime.Now.AddYears(-3))
            {
                return false;
            }
            return true;
        }

    }
}
