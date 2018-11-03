using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class CNH
    {
        public string cnh;
        public DateTime dataValidadeCNH;

        public CNH(string cnh, DateTime validadeCNH)
        {
            this.cnh = cnh ;
            this.dataValidadeCNH = validadeCNH;
        }

        /*Se a data for menor que a data atual -- CNH fora da validade*/
        public bool verificaDataValidadeCNH()
        {
            if (dataValidadeCNH < DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }
}
