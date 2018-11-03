using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class MultasHash
    {
        Multas[] _hashtab;

        internal Multas[] Hashtab
        {
            get { return _hashtab; }
            set { _hashtab = value; }
        }

        public MultasHash()
        {
            _hashtab = new Multas[999979];

        }

        public void inserir(Multas Novo)
        {
            long code = Novo.veiculo.placa.GetHashCode();
            if (code < 0)
            {
                code = code * -1;
            }
            code = code % 999979;
            if (Hashtab[code] == null)
            {
                Hashtab[code] = Novo;
            }
            else
            {
                inserir(Novo, 1);
            }

        }

        public void inserir(Multas novo, int rehash)
        {
            long code = novo.veiculo.placa.GetHashCode();
            if (code < 0)
            {
                code = code * -1;
            }
            code = code % 999979;
            code = ReHash(code, rehash);
            if (Hashtab[code] == null)
            {
                Hashtab[code] = novo;
            }
            else
            {
                inserir(novo, rehash + 1);
            }
        }

        public long ReHash(long code, int rehash)
        {
            code = code * (rehash + 1);
            if (code > 999979)
            {
                code = code % 999979;
            }
            return code;
        }

        public Multas procurar(string placa, long cnh, DateTime dataEmissao)
        {
            Multas holder;
            long code = placa.GetHashCode();
            if (code < 0)
            {
                code = code * -1;
            }
            code = code % 999979;
            if (Hashtab[code] == null)
            {
                return null;
            }
            else
            {
                if (Hashtab[code].veiculo.placa.Equals(placa) 
                    && Hashtab[code].condutor.habilitacaoCondutor.cnh == cnh.ToString()
                    && Hashtab[code].dataEmissao.Equals(dataEmissao))
                {
                    holder = Hashtab[code];
                    return holder;
                }
                else
                {
                    code = ReHash(code, 1);
                    return procurar(placa, cnh, dataEmissao, code, 1);
                }
            }
        }

        public Multas procurar(string placa, long cnh, DateTime dataEmissao, long code, int rehash)
        {
            Multas holder;

            if (Hashtab[code] == null)
            {
                return null;
            }
            else
            {
                if (Hashtab[code].veiculo.placa.Equals(placa) 
                    && Hashtab[code].condutor.habilitacaoCondutor.cnh == cnh.ToString()
                    && Hashtab[code].dataEmissao.Equals(dataEmissao))
                {
                    holder = Hashtab[code];
                    return holder;
                }
                else
                {
                    code = ReHash(code, rehash + 1);
                    return procurar(placa, cnh, dataEmissao, code, rehash + 1);
                }
            }
        }

        public void CopiaHash(ref Multas[] array)
        {

            int cont = 0;
            for (int i = 0; i < Hashtab.Length; i++)
            {
                if (!(Hashtab[i] == null))
                {
                    cont++;
                }
            }
            array = new Multas[cont];
            cont = 0;
            for (int i = 0; i < Hashtab.Length; i++)
            {
                if (Hashtab[i] != null)
                {
                    array[cont] = Hashtab[i];
                    cont++;
                }
            }
        }
    }
}