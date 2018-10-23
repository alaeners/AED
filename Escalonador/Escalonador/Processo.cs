using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador
{
    public class Processo
    {
        int pid;
        string nome;
        int prioridade;
        int numciclos;

        public Processo(int pid, string nome, int prioridade, int numciclos)
        {
            this.Pid = pid;
            this.Nome = nome;
            this.Prioridade = prioridade;
            this.Numciclos = numciclos;
        }

        public int Pid { get => pid; set => pid = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public int Numciclos { get => numciclos; set => numciclos = value; }
    }
}
