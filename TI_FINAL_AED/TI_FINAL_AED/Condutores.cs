using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_FINAL_AED
{
    public class Condutores
    {
        string nomeCondutor; 
        public CNH habilitacaoCondutor;
        MultasListas listaMultasPorCondutor;

        public Condutores(string nome, CNH cnh)
        {
            this.nomeCondutor = nome;
            this.habilitacaoCondutor = cnh;
        }


        // verifica se o condutor esta com a CNH regular
        public bool verificarRegularidadeCNH()
        {
            if (listaMultasPorCondutor.verificaPontuacaoMultas() > 21)
            {
                return false;
            }
            return true;
        }

        //Soma os valores das multas que existem para o condutor
        public double verificarValoresDasMultas()
        {
            return listaMultasPorCondutor.verificaValoresMultas();
        }

        public VeiculosListas GetVeiculosComMulta()
        {
            VeiculosListas veiculosComMultaPorCondutor = listaMultasPorCondutor.GetVeiculosComMultas();
            return veiculosComMultaPorCondutor;
        }
    }
}