using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TI_FINAL_AED
{
    public partial class Entrada : Form
    {
        CondutoresHash tabelaHashCondutores = new CondutoresHash();
        MultasHash tabelaHashMultas = new MultasHash();
        VeiculosHash tabelaHashVeiculos = new VeiculosHash();
        bool condutoresFlag = false;
        bool veiculosFlag = false;

        public Entrada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void veículosPorCondutorEMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarVeiculosConduziuLevouMulta listarVeiculosConduziuLevouMulta = new ListarVeiculosConduziuLevouMulta(tabelaHashCondutores);
            this.Hide();
            listarVeiculosConduziuLevouMulta.ShowDialog();
            this.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void condutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] cnhCondutores = File.ReadAllLines("condutores.txt");
            string cnhNum, nomeCondutor;
            DateTime dataVencimentoCnh;
            int cont = 0; 

            for (int i = 0; i < cnhCondutores.Length; i++)
            {
                cnhNum = cnhCondutores[i].Split(';')[1];
                nomeCondutor = cnhCondutores[i].Split(';')[0];
                dataVencimentoCnh = Convert.ToDateTime(cnhCondutores[i].Split(';')[2]);
                                
                CNH cnh = new CNH(cnhNum, dataVencimentoCnh);
                Condutores condutor = new Condutores(nomeCondutor, cnh);
                tabelaHashCondutores.inserir(condutor);
                cont++;
            }
            condutoresToolStripMenuItem.Enabled = false;
            MessageBox.Show("Foram Lidos: " + cont + " Condutores");
            condutoresFlag = true;
        }

        private void multasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (condutoresFlag && veiculosFlag)
            {
                String[] multas = File.ReadAllLines("multas.txt");
                DateTime dataEmissaoMulta;
                string cnh, placa, tipoMulta;
                int cont = 0;

                for (int i = 0; i < multas.Length; i++)
                {
                    cnh = multas[i].Split(';')[0];
                    placa = multas[i].Split(';')[1];
                    dataEmissaoMulta = Convert.ToDateTime(multas[i].Split(';')[3]);
                    tipoMulta = multas[i].Split(';')[2];

                    Condutores condutor = tabelaHashCondutores.buscar(cnh);
                    Veiculos veiculo = tabelaHashVeiculos.buscar(placa);
                    Multas multa = null;
                    switch (tipoMulta)
                    {
                        case "1":
                            multa = new Leves(dataEmissaoMulta, veiculo, condutor);
                            break;

                        case "2":
                            multa = new Medias(dataEmissaoMulta, veiculo, condutor);
                            break;

                        case "3":
                            multa = new Graves(dataEmissaoMulta, veiculo, condutor);
                            break;

                        default:
                            break;
                    }
                    tabelaHashMultas.inserir(multa);
                    condutor.listaMultasPorCondutor.inserir(multa);
                    veiculo.listaMultasPorVeiculo.inserir(multa);
                    cont++;
                }
                multasToolStripMenuItem.Enabled = false;
                MessageBox.Show("Foram Lidas: " + cont + " Multas");
            }
            else
            {
                MessageBox.Show("Os dados de Veículos("+veiculosFlag+") ou Condutores("+condutoresFlag+") não foram carregados. Impossível executar essa ação.");
            }
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] veiculos = File.ReadAllLines("veiculos.txt");
            string placa = null;
            int cont = 0;

            for (int i = 0; i < veiculos.Length; i++)
            {
                placa = veiculos[i].Split(';')[0];
                Veiculos veiculo = new Veiculos(placa);
                tabelaHashVeiculos.Inserir(veiculo);
                cont++;
            }
            veículosToolStripMenuItem.Enabled = false;
            MessageBox.Show("Foram Lidos: " + cont + " Veículos");
            veiculosFlag = true;
            
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }

        private void listarMultasPorVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarMultasPorVeiculo listarVeiculosPorMultas = new ListarMultasPorVeiculo(tabelaHashVeiculos);
            this.Hide();
            listarVeiculosPorMultas.ShowDialog();
            this.Show();
        }
        private void listarRelatórioDeVeículosSemMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioDeVeiculoSemMulta relatorioDeVeiculosSemMulta = new RelatorioDeVeiculoSemMulta(tabelaHashVeiculos);
            this.Hide();
            relatorioDeVeiculosSemMulta.ShowDialog();
            this.Show();
        }
        private void verificarRegularidadeDoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeiculoOuCondutorIrregular veiculoIrregular = new VeiculoOuCondutorIrregular(true,false, tabelaHashVeiculos, tabelaHashCondutores);
            this.Hide();
            veiculoIrregular.ShowDialog();
            this.Show();
        }
        private void verificarRegularidadeDoCondutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeiculoOuCondutorIrregular condutorIrregular = new VeiculoOuCondutorIrregular(false, true, tabelaHashVeiculos, tabelaHashCondutores);
            this.Hide();            
            condutorIrregular.ShowDialog();
            this.Show();
        }

        private void condutorIrregularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtratoDeMultasDeUmCondutor extrato = new ExtratoDeMultasDeUmCondutor(tabelaHashCondutores);
            this.Hide();
            extrato.ShowDialog();
            this.Show();
        }

        private void taxasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (condutoresFlag && veiculosFlag)
            { 
                String[] taxas = File.ReadAllLines("impostos.txt");
                string placa;
                int ano;
                Veiculos veiculo;
                int cont = 0;

                for (int i = 0; i < taxas.Length; i++)
                {
                    placa = taxas[i].Split(';')[0];
                    ano = int.Parse(taxas[i].Split(';')[2]);

                    veiculo = tabelaHashVeiculos.buscar(placa);

                    veiculo.inserirTaxa(taxas[i].Split(';')[1], ano);
                    cont++;
                }
                taxasToolStripMenuItem.Enabled = false;
                MessageBox.Show("Foram Lidas: " + cont + " Taxas");
            }
            else
            {
                MessageBox.Show("Os dados de Veículos("+veiculosFlag+") ou Condutores("+condutoresFlag+") não foram carregados. Impossível executar essa ação.");
            }
        }

        private void carregarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para funcionamento é necessário carregar: CONDUTORES OU VEICULOS :primeiro");
        }
    }
}