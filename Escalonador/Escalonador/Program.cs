using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escalonador
{
    class Program
    {
        static ListaCircular[] FilasPrioridade = new ListaCircular[20];
        static void Main(string[] args)
        {
            for (int i = 0; i < FilasPrioridade.Length; i++)
            {
                FilasPrioridade[i] = new ListaCircular();
            }

            LerArquivos();
            bool promover = false;

            while (!FilasVazias(promover))
            {
                promover = true;
                Processar();
            }
            

            Console.ReadKey();
        }

        private static bool FilasVazias(bool promover)
        {
            bool temProcesso = false;

            for (int i = 0; i < FilasPrioridade.Length; i++)
            {
                if (!FilasPrioridade[i].Vazia())
                {
                    temProcesso = true;

                    if (i != 0)
                    {
                        if (promover && FilasPrioridade[i].Contar() > (20 - i))
                        {
                            PromoverProcesso(FilasPrioridade[i].Remover(1));
                        }
                    }
                    else
                    {
                        if (promover && FilasPrioridade[i].Contar() > 20)
                        {
                            RebaixarProcesso(FilasPrioridade[i].Remover(1));
                        }
                    }
                }
            }

            return !temProcesso;
        }

        private static void RebaixarProcesso(Processo processo)
        {
            processo.Prioridade++;
            FilasPrioridade[processo.Prioridade - 1].InserirUltimo(processo);
            Console.WriteLine($@"Processo {processo.Pid} rebaixado para fila de prioridade {processo.Prioridade}");
        }

        private static void PromoverProcesso(Processo processo)
        {
            processo.Prioridade--;
            FilasPrioridade[processo.Prioridade - 1].InserirUltimo(processo);
            Console.WriteLine($@"Processo {processo.Pid} promovido para fila de prioridade {processo.Prioridade}");
        }

        private static void Processar()
        {
            for (int i = 0; i < FilasPrioridade.Length; i++)
            {
                for (int j = 0;  j < 20 - i && j < FilasPrioridade[i].Contar();  j++)
                {
                    Processo processo = FilasPrioridade[i].Remover(1);

                    ExecutarProcesso(processo);
                    if (processo.Numciclos > 0)
                    {
                        Console.WriteLine($@"Processo {processo.Pid} retornado para fila de espera de prioridade {processo.Prioridade}");
                        FilasPrioridade[processo.Prioridade - 1].InserirUltimo(processo);
                    }
                    else
                    {
                        Console.WriteLine($@"Processo {processo.Pid} encerrou sua execução");
                    }
                }
            }

            Console.WriteLine("Todos os processos encerraram sua execução");
        }

        private static void ExecutarProcesso(Processo processo)
        {
            Console.WriteLine($@"Executando processo {processo.Pid}");
            Thread.Sleep(100);
            processo.Numciclos--;
        }

        private static void LerArquivos()
        {
            string[] arquivo = File.ReadAllLines("processos.txt");
            foreach (string linha in arquivo)
            {
                string[] aux = linha.Split(';');
                int pid = int.Parse(aux[0]);
                string nome = aux[1];
                int prioridade = int.Parse(aux[2]);
                int numciclos = int.Parse(aux[3]);

                Processo NovoProcesso = new Processo(pid, nome, prioridade, numciclos);

                FilasPrioridade[prioridade - 1].InserirUltimo(NovoProcesso);

                Console.WriteLine($@"Processo de id {pid} inserido na fila de prioridade {prioridade}");
            }
        }
    }
}
