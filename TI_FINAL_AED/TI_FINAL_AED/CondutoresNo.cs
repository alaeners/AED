using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    /// <summary>
    /// Essa classe cria as listas de multas passando os multa como referencia.
    /// </summary>
    public class CondutoresNo
    {
        Condutores _condutor;
        CondutoresNo _prox;

        public Condutores condutor
        {
            get { return _condutor; }
            set { _condutor = value; }
        }        

        internal CondutoresNo prox
        {
            get { return _prox; }
            set { _prox = value; }
        }

        public CondutoresNo()
        {
            condutor = null;
            prox = null;
        }

        public CondutoresNo(Condutores Novo)
        {
            this.condutor = Novo;
            prox = null;
        }
    }

}