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
    public partial class RelatorioDeVeiculoSemMulta : Form
    {
        VeiculosHash veiculosHash = new VeiculosHash();
        public RelatorioDeVeiculoSemMulta(VeiculosHash tabelaVeiculosHash)
        {
            InitializeComponent();
            this.veiculosHash = tabelaVeiculosHash;

        }

        private void RelatorioDeVeiculoSemMulta_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < veiculosHash.hashtab.Length; i++)
            {
                VeiculosNo auxVeiculosNo;
                auxVeiculosNo = veiculosHash.hashtab[i].sentinela;
                while (auxVeiculosNo.prox != null)
                {
                    auxVeiculosNo = auxVeiculosNo.prox;
                    if (auxVeiculosNo.veiculo.listaMultasPorVeiculo.vazia())
                    {
                        veiculosSemMultalistView.Items.Add(auxVeiculosNo.veiculo.placa);
                    }
                }
            }
        }
    }
}
