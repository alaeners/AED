using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class CondutoresHash
    {
        CondutoresListas[] _hashtab;

        public int contaColisao()
        {
            int colisao = 0;
            for (int i = 0; i < hashtab.Length; i++)
            {
                colisao = colisao + hashtab[i].colisao;
            }
            return colisao;
        }

        public CondutoresHash()
        {
            hashtab = new CondutoresListas[1490000];
            for (int i = 0; i < hashtab.Length; i++)
            {
                hashtab[i] = new CondutoresListas();
            }
        }

        public CondutoresListas[] hashtab
        {
            get
            {
                return _hashtab;
            }

            set
            {
                _hashtab = value;
            }
        }

        private long hashCode(long cnh)
        {
            return cnh % 1490001;
        }
        public void inserir(Condutores novo)
        {
            hashtab[hashCode(long.Parse(novo.habilitacaoCondutor.cnh))].inserir(novo);
        }

        public Condutores buscar(string cnh)
        {
            Condutores holder = hashtab[hashCode(long.Parse(cnh))].procurar(cnh);
            return holder;
        }
    }
}
