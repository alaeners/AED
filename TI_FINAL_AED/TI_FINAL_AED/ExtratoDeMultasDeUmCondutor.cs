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
    public partial class ExtratoDeMultasDeUmCondutor : Form
    {
        CondutoresHash condutores = new CondutoresHash();
        public ExtratoDeMultasDeUmCondutor(CondutoresHash condutoresHash)
        {
            InitializeComponent();
            this.condutores = condutoresHash;
        }

        private void ExtratoDeMultasDeUmCondutor_Load(object sender, EventArgs e)
        {

        }
        private void listarExtratoButton_Click(object sender, EventArgs e)
        {
           string cnhCondutor = cnhExtratoMaskTextBox.Text;
           Condutores condutor = condutores.buscar(long.Parse(cnhCondutor));
           MultasNo auxMultas = condutor.listaMultasPorCondutor.sentinela;
            while (auxMultas.prox != null)
            {
                auxMultas = auxMultas.prox;
                listView1.Items.Add(auxMultas.ToString());
            }

        }
    }
}
