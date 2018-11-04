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
            String[] cnhCondutores = File.ReadAllLines("");
            string cnhNum, nomeCondutor;
            DateTime dataVencimentoCnh;

            for (int i = 0; i < cnhCondutores.Length; i++)
            {
                cnhNum = cnhCondutores[i].Split(';')[0];
                nomeCondutor = cnhCondutores[i].Split(';')[1];
                dataVencimentoCnh = Convert.ToDateTime(cnhCondutores[i].Split(';')[2]);
                                
                CNH cnh = new CNH(cnhNum, dataVencimentoCnh);
                Condutores condutor = new Condutores(nomeCondutor, cnh);
                tabelaHashCondutores.inserir(condutor);
            }            
        }

        private void multasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] multas = File.ReadAllLines("");
            DateTime dataEmissaoMulta;
            string cnh, placa, tipoMulta;

            for (int i = 0; i < multas.Length; i++)
            {
                cnh = multas[i].Split(';')[0];
                placa = multas[i].Split(';')[1];
                dataEmissaoMulta = Convert.ToDateTime(multas[i].Split(';')[2]);
                tipoMulta = multas[i].Split(';')[4];

                Condutores condutor = tabelaHashCondutores.buscar(long.Parse(cnh));
                Veiculos veiculo = tabelaHashVeiculos.buscar(placa);
                Multas multa = null;
                switch (tipoMulta)
                {
                    case "Leve":
                        multa = new Leves(dataEmissaoMulta, veiculo, condutor);
                        break;

                    case "Media":
                        multa = new Medias(dataEmissaoMulta, veiculo, condutor);
                        break;

                    case "Grave":
                        multa = new Graves(dataEmissaoMulta, veiculo, condutor);
                        break;

                    default:
                        break;
                }
                tabelaHashMultas.inserir(multa);
                condutor.listaMultasPorCondutor.inserir(multa);
                veiculo.listaMultasPorVeiculo.inserir(multa);
            }
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] veiculos = File.ReadAllLines("");
            DateTime dataIPVA = new DateTime();
            DateTime dataLicenciamento = new DateTime();
            DateTime dataSeguroObrigatorio = new DateTime(); 
            string placa = null; 

            for (int i = 0; i < veiculos.Length; i++)
            {
                placa = veiculos[i].Split(';')[0];
                dataIPVA = Convert.ToDateTime(veiculos[i].Split(';')[1]);
                dataLicenciamento = Convert.ToDateTime(veiculos[i].Split(';')[2]);
                dataSeguroObrigatorio = Convert.ToDateTime(veiculos[i].Split(';')[3]);
            }
            Veiculos veiculo = new Veiculos(placa, dataIPVA, dataLicenciamento, dataSeguroObrigatorio);
            tabelaHashVeiculos.Inserir(veiculo);
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
    }
}