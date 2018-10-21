using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_with_SO
{
    class Program
    {
        static void Main(string[] args)
        {
            Processo processo;

            StreamReader rd = new StreamReader(ofd.FileName, true);
            string[] dados;
            string linha;

            while (!rd.EndOfStream)
            {
                linha = rd.ReadLine();
                dados = linha.Split(';');
                processo = new Processo(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), float.Parse(dados[3]), int.Parse(dados[4]));
                ListaProcessos.Add(processo);
            }

        }
    }
}
