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
    public class VeiculosNo
    {

        Veiculos _veiculo;

        public Veiculos veiculo
        {
            get { return _veiculo; }
            set { _veiculo = value; }
        }
        VeiculosNo _prox;

        internal VeiculosNo prox
        {
            get { return _prox; }
            set { _prox = value; }
        }

        public VeiculosNo(Veiculos novo)
        {
            veiculo = novo;
            prox = null;
        }

        public VeiculosNo()
        {
            veiculo = null;
            prox = null;
        }
    }
}