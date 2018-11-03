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
    public class MultasNo
    {
        Multas _multa;
        MultasNo _ant;
        MultasNo _prox;
        public Multas multa
        {
            get { return _multa; }
            set { _multa = value; }
        }


        internal MultasNo prox
        {
            get { return _prox; }
            set { _prox = value; }
        }

        internal MultasNo ant
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

        public MultasNo()
        {
            _multa = null;
        }
        public MultasNo(Multas Dados)
        {
            _multa = Dados;
            _prox = null;
        }
    }
}