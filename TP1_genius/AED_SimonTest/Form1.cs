using SimonBase;
using System;
using System.Windows.Forms;

namespace AED_SimonTest
{
    public partial class Form1 : SimonForm
    {
        //Botao[] teste = { Botao.AMARELO, Botao.VERDE, Botao.AMARELO, Botao.VERMELHO, Botao.VERMELHO, Botao.AZUL, Botao.VERDE };
        Queue simon;
        Queue player;
        int nivel = 1;

        public bool verificaNivel()
        {
            if (nivel == player.Count())
            {
                return true;
            }
            else return false;
        }

        public bool comparaFilas()
        {
            if (simon.CompareQueue(player))
            {
                return true;
            }
            else return false;
        }

        public void gameIsOnOrOver()
        {
            if (verificaNivel())
            {
                if (comparaFilas())
                {
                    nivel++;
                    switchPanel();
                    player = null;
                    button1_Click(this, new EventArgs());
                }
                else
                {
                    nivel = 1;
                    simon = null;
                    player = null;
                    switchPanel();
                    MessageBox.Show("PERDEU MANO, TENTA DE NOVO");
                    btnTeste.Enabled = true;
                }
            }
        }
        public Form1() : base()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnTeste.Enabled = false;
            int botao = new Random().Next(0, 3);            
            if (simon == null)
            {
                simon = new Queue((Botao)botao);
            }
            else
            {
                simon.Enqueue((Botao)botao);
            }
            Item aux = simon.frente;
            click(aux.botao);
            while (aux.next != null)
            {   
                aux = aux.next;
                System.Threading.Thread.Sleep(400);
                click(aux.botao);
            }
            System.Threading.Thread.Sleep(400);
            switchPanel();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnVerde_Click(object sender, EventArgs e)
        {
            if (player == null)
            {
                player = new Queue(Botao.VERDE);
            }
            else
            {
                player.Enqueue(Botao.VERDE);
            }

            click(Botao.VERDE);
            btnVerde.Checked = false;
            gameIsOnOrOver();
        }
        private void btnVermelho_Click(object sender, EventArgs e)
        {
            if (player == null)
            {
                player = new Queue(Botao.VERMELHO);
            }
            else
            {
                player.Enqueue(Botao.VERMELHO);
            }

            click(Botao.VERMELHO);
            btnVermelho.Checked = false;
            gameIsOnOrOver();
        }
        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            if (player == null)
            {
                player = new Queue(Botao.AMARELO);
            }
            else
            {
                player.Enqueue(Botao.AMARELO);
            }

            click(Botao.AMARELO);
            btnAmarelo.Checked = false;
            gameIsOnOrOver();
        }
        private void btnAzul_Click(object sender, EventArgs e)
        {
            if (player == null)
            {
                player = new Queue(Botao.AZUL);
            }
            else
            {
                player.Enqueue(Botao.AZUL);
            }

            click(Botao.AZUL);
            btnAzul.Checked = false;
            gameIsOnOrOver();
        }
        private void switchPanel()
        {
            btnAmarelo.Enabled = !btnAmarelo.Enabled;
            btnVerde.Enabled = !btnVerde.Enabled;
            btnAzul.Enabled = !btnAzul.Enabled;
            btnVermelho.Enabled = !btnVermelho.Enabled;

            for (int i = 0; i < 4; i++)
            {
                paineis[i].Enabled = !paineis[i].Enabled;
            }
        }
    }
}