using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_FINAL_AED
{
    public partial class ListarVeiculosConduziuLevouMulta : Form
    {
        CondutoresHash condutoresHash;

        public ListarVeiculosConduziuLevouMulta(CondutoresHash condutoresHash)
        {
            InitializeComponent();
            this.condutoresHash = condutoresHash;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veículosPorCondutorEMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cnhMaskTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            veiculosComMultaPorCondutorlistView.Items.Clear();
            string cnhCondutor = cnhMaskTextBox.Text;
            Condutores condutor = condutoresHash.buscar(cnhCondutor);
            if (condutor != null)
            {
                VeiculosListas veiculosComMultaPorCondutor = condutor.GetVeiculosComMulta();
                VeiculosNo auxVeiculo = veiculosComMultaPorCondutor.sentinela;
                while (auxVeiculo.prox != null)
                {
                    auxVeiculo = auxVeiculo.prox;
                    veiculosComMultaPorCondutorlistView.Items.Add(auxVeiculo.veiculo.placa);
                }
            }
            else
            {
                MessageBox.Show("Condutor não encontrado");
            }
        }

        private void ListarVeiculosConduziuLevouMulta_Load(object sender, EventArgs e)
        {

        }
    }
}
