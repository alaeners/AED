using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class TaxasNo
    {
        Taxas _taxa;
        TaxasNo _ant;
        TaxasNo _prox;
        public Taxas taxa
        {
            get { return _taxa; }
            set { _taxa = value; }
        }


        internal TaxasNo prox
        {
            get { return _prox; }
            set { _prox = value; }
        }

        internal TaxasNo ant
        {
            get
            {
                return _ant;
            }

            set
            {
                _ant = value;
            }
        }

        public TaxasNo()
        {
            _taxa = null;
        }
        public TaxasNo(Taxas Dados)
        {
            _taxa = Dados;
            _prox = null;
        }
    }
}

