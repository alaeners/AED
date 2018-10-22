using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TI_with_SO
{
    class Program
    {
        static ListaCircular ListaProcessos;

        //Métodos que vão dar certo:
        public static void LerArquivoCerto()
        {
            StreamReader rd = new StreamReader("Arquivo.txt");
            string[] dados;
            string linha;

            while (!rd.EndOfStream)
            {
                linha = rd.ReadLine();
                dados = linha.Split(';');
                Processo processo = new Processo(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), float.Parse(dados[3]), int.Parse(dados[4]));
                ListaProcessos.InserirPrimero(processo);
            }
            rd.Close();
        }
        static void Main(string[] args)
        {
            LerArquivoCerto();
            Console.ReadKey();
        }
    }
}
