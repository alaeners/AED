using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_with_SO
{
    public class Processo
    {
        // Atributos
        private int pid;
        private string nomeProcesso;
        private int prioridade;
        private float tmpChegada;
        private int tmpServico;
        private string status;


        // Geters e Seters
        public int Pid { get{ return pid;} set{ pid = value; }}
        public string NomeProcesso { get{ return nomeProcesso;} set{ nomeProcesso = value;}}
        public int Prioridade { get{ return prioridade;} set{prioridade = value;}}
        public float TmpChegada { get{ return tmpChegada;} set{tmpChegada = value;}}
        public int TmpServico { get{ return tmpServico;} set{tmpServico = value;}}
        public string Status { get { return status;} set { status = value;}}

        //Construtor
        public Processo (int pid, string nomeProcesso, int prioridade, float tmpChegada, int tmpServico)
        {
            this.pid = pid;
            this.nomeProcesso = nomeProcesso;
            this.prioridade = prioridade;
            this.tmpChegada = tmpChegada;
            this.tmpServico = tmpServico;
            this.status = "Pronto";

        }
    }
}
