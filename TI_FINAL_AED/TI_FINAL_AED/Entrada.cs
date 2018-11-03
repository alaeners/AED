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
            listarVeiculosConduziuLevouMulta.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void condutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] cnhCondutores = File.ReadAllLines("");
            for (int i = 0; i < cnhCondutores.Length; i++)
            {
                string cnhNum, nomeCondutor;
                DateTime dataVencimentoCnh;

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
            for (int i = 0; i < multas.Length; i++)
            {

            }
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] veiculos = File.ReadAllLines("");
            for (int i = 0; i < veiculos.Length; i++)
            {

            }

        }
    }
}