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
    public partial class ListarMultasPorVeiculo : Form
    {
        VeiculosHash veiculosHash;
        public ListarMultasPorVeiculo(VeiculosHash tabelaHashVeiculos)
        {
            InitializeComponent();
            veiculosHash = tabelaHashVeiculos;
        }

        private void ListarMultasPorVeiculo_Load(object sender, EventArgs e)
        {
          
        }

        private void listaMultaPorVeiculoButton_Click(object sender, EventArgs e)
        {
            if (placaMaskedTextBox.Text == "")
            {
                MessageBox.Show("Campo Vazio - Informe uma Placa");
            }
            else
            {
                multasPorVeiculoListView.Items.Clear();
                string placa = placaMaskedTextBox.Text.ToUpper();
                Veiculos veiculo = veiculosHash.buscar(placa);
                
                if (veiculo != null)
                {
                    Multas[] vetMulta = veiculo.listaMultasPorVeiculo.OrdenaMultas();

                    foreach (var multa in vetMulta)
                    {
                        multasPorVeiculoListView.Items.Add(multa.condutor.habilitacaoCondutor.cnh + " " + multa.dataEmissao.ToShortDateString());
                    }

                    //MultasNo auxMultas = veiculo.listaMultasPorVeiculo.sentinela;
                    //while (auxMultas.prox != null)
                    //{
                    //    auxMultas = auxMultas.prox;
                    //    multasPorVeiculoListView.Items.Add(auxMultas.multa.condutor.habilitacaoCondutor.cnh + " " + auxMultas.multa.dataEmissao.ToShortDateString());
                    //}
                }
                else
                {
                    MessageBox.Show("Veículo não encontrado");
                }
            }
        }
    }
}
