using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class VeiculosHash
    {
        VeiculosListas[] _hashtab;


        public int contaColisao()
        {
            int cont = 0;
            for (int i = 0; i < hashtab.Length; i++)
            {
                cont = cont + hashtab[i].colisao;
            }
            return cont;
        }
        public VeiculosHash()
        {
            hashtab = new VeiculosListas[10000];
            for (int i = 0; i < hashtab.Length; i++)
            {
                hashtab[i] = new VeiculosListas();
            }
        }
        public VeiculosListas[] hashtab
        {
            get { return _hashtab; }
            set { _hashtab = value; }
        }

        public void Inserir(Veiculos novo)
        {
            hashtab[hashCodeNumerica(novo.placa)].inserir(novo);
        }

        private int hashCodeNumerica(string placa)
        {
            int parteNumerica;
            parteNumerica = int.Parse(placa.Substring(4));
            return parteNumerica;
        }

        public Veiculos buscar(string placa)
        {
            Veiculos holder = hashtab[hashCodeNumerica(placa)].procurar(placa);
            return holder;
        }
    }
}