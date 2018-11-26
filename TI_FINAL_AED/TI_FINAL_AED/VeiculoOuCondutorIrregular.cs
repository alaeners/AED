using System;
using System.Windows.Forms;

namespace TI_FINAL_AED
{
    public partial class VeiculoOuCondutorIrregular : Form
    {
        VeiculosHash veiculos = new VeiculosHash();
        CondutoresHash condutores = new CondutoresHash();
        public VeiculoOuCondutorIrregular(bool veiculo, bool condutor, VeiculosHash veiculoHash, CondutoresHash condutoresHash )
        {
            InitializeComponent();
            this.veiculos = veiculoHash;
            this.condutores = condutoresHash;

            if (veiculo)
            {
                verificaPlacaButton.Visible = true;
                placaRegularLabel.Visible = true;
                placaMaskedTextBox.Visible = true;
            }
            else
            {
                verificaPlacaButton.Visible = false;
                placaRegularLabel.Visible = false;
                placaMaskedTextBox.Visible = false;
            }

            if (condutor)
            {
                verificaCNHButton.Visible = true;
                cnhRegularLabel.Visible = true;
                cnhMaskedTextBox.Visible = true;
            }
            else
            {
                verificaCNHButton.Visible = false;
                cnhRegularLabel.Visible = false;
                cnhMaskedTextBox.Visible = false;
            }


        }

        private void VeiculoOuCondutorIrregular_Load(object sender, EventArgs e)
        {

        }

        private void cnhMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void placaMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void verificaPlacaButton_Click(object sender, EventArgs e)
        {
            string placa = placaMaskedTextBox.Text;
            Veiculos veiculo = veiculos.buscar(placa);
            if (veiculo != null)
            {
                if (veiculo.verificaRegularidadeVeiculo())
                {
                    MessageBox.Show("Veículo Regular");
                }
                else
                {
                    MessageBox.Show("Veículo Irregular");
                }
            }
            else
            {
                MessageBox.Show("Veículo não encontrado");
            }
        }
        private void verificaCNHButton_Click(object sender, EventArgs e)
        {
            string cnhCondutor = cnhMaskedTextBox.Text;
            Condutores condutor = condutores.buscar(cnhCondutor);
            if (condutor != null)
            {
                if (condutor.verificarRegularidadeCNH())
                {
                    MessageBox.Show("Condutor Regular");
                }
                else
                {
                    MessageBox.Show("Condutor Irregular");
                }
            }
            else
            {
                MessageBox.Show("Condutor não encontrado");
            }
        }
    }
}