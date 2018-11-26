namespace TI_FINAL_AED
{
    partial class Entrada
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosPorCondutorEMultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasPorVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMultasPorVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarRelatórioDeVeículosSemMultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosSemMultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarRegularidadeDoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarRegularidadeDoCondutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condutorIrregularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taxasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.pesquisasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarDadosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // carregarDadosToolStripMenuItem
            // 
            this.carregarDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.condutoresToolStripMenuItem,
            this.multasToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.taxasToolStripMenuItem});
            this.carregarDadosToolStripMenuItem.Name = "carregarDadosToolStripMenuItem";
            this.carregarDadosToolStripMenuItem.Size = new System.Drawing.Size(415, 22);
            this.carregarDadosToolStripMenuItem.Text = "Ler os dados acima de arquivos de condutores, veículos e multas";
            // 
            // condutoresToolStripMenuItem
            // 
            this.condutoresToolStripMenuItem.Name = "condutoresToolStripMenuItem";
            this.condutoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.condutoresToolStripMenuItem.Text = "Condutores";
            this.condutoresToolStripMenuItem.Click += new System.EventHandler(this.condutoresToolStripMenuItem_Click);
            // 
            // multasToolStripMenuItem
            // 
            this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            this.multasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multasToolStripMenuItem.Text = "Multas";
            this.multasToolStripMenuItem.Click += new System.EventHandler(this.multasToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(415, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pesquisasToolStripMenuItem
            // 
            this.pesquisasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículosPorCondutorEMultaToolStripMenuItem,
            this.multasPorVeículosToolStripMenuItem,
            this.veículosSemMultasToolStripMenuItem,
            this.condutorIrregularToolStripMenuItem});
            this.pesquisasToolStripMenuItem.Name = "pesquisasToolStripMenuItem";
            this.pesquisasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisasToolStripMenuItem.Text = "Pesquisar";
            // 
            // veículosPorCondutorEMultaToolStripMenuItem
            // 
            this.veículosPorCondutorEMultaToolStripMenuItem.Name = "veículosPorCondutorEMultaToolStripMenuItem";
            this.veículosPorCondutorEMultaToolStripMenuItem.Size = new System.Drawing.Size(435, 22);
            this.veículosPorCondutorEMultaToolStripMenuItem.Text = "Listar os veículos que um condutor dirigiu e levou multa.";
            this.veículosPorCondutorEMultaToolStripMenuItem.Click += new System.EventHandler(this.veículosPorCondutorEMultaToolStripMenuItem_Click);
            // 
            // multasPorVeículosToolStripMenuItem
            // 
            this.multasPorVeículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarMultasPorVeículoToolStripMenuItem,
            this.listarRelatórioDeVeículosSemMultasToolStripMenuItem});
            this.multasPorVeículosToolStripMenuItem.Name = "multasPorVeículosToolStripMenuItem";
            this.multasPorVeículosToolStripMenuItem.Size = new System.Drawing.Size(435, 22);
            this.multasPorVeículosToolStripMenuItem.Text = "Listar multas por veículo e criar um relatório de veículos sem multas.";
            // 
            // listarMultasPorVeículoToolStripMenuItem
            // 
            this.listarMultasPorVeículoToolStripMenuItem.Name = "listarMultasPorVeículoToolStripMenuItem";
            this.listarMultasPorVeículoToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.listarMultasPorVeículoToolStripMenuItem.Text = "Listar multas por veículo";
            this.listarMultasPorVeículoToolStripMenuItem.Click += new System.EventHandler(this.listarMultasPorVeículoToolStripMenuItem_Click);
            // 
            // listarRelatórioDeVeículosSemMultasToolStripMenuItem
            // 
            this.listarRelatórioDeVeículosSemMultasToolStripMenuItem.Name = "listarRelatórioDeVeículosSemMultasToolStripMenuItem";
            this.listarRelatórioDeVeículosSemMultasToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.listarRelatórioDeVeículosSemMultasToolStripMenuItem.Text = "Listar relatório de veículos sem multas.";
            this.listarRelatórioDeVeículosSemMultasToolStripMenuItem.Click += new System.EventHandler(this.listarRelatórioDeVeículosSemMultasToolStripMenuItem_Click);
            // 
            // veículosSemMultasToolStripMenuItem
            // 
            this.veículosSemMultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarRegularidadeDoVeículoToolStripMenuItem,
            this.verificarRegularidadeDoCondutorToolStripMenuItem});
            this.veículosSemMultasToolStripMenuItem.Name = "veículosSemMultasToolStripMenuItem";
            this.veículosSemMultasToolStripMenuItem.Size = new System.Drawing.Size(435, 22);
            this.veículosSemMultasToolStripMenuItem.Text = "Responder se um veículo ou condutor está irregular.";
            // 
            // verificarRegularidadeDoVeículoToolStripMenuItem
            // 
            this.verificarRegularidadeDoVeículoToolStripMenuItem.Name = "verificarRegularidadeDoVeículoToolStripMenuItem";
            this.verificarRegularidadeDoVeículoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.verificarRegularidadeDoVeículoToolStripMenuItem.Text = "Verificar regularidade do veículo";
            this.verificarRegularidadeDoVeículoToolStripMenuItem.Click += new System.EventHandler(this.verificarRegularidadeDoVeículoToolStripMenuItem_Click);
            // 
            // verificarRegularidadeDoCondutorToolStripMenuItem
            // 
            this.verificarRegularidadeDoCondutorToolStripMenuItem.Name = "verificarRegularidadeDoCondutorToolStripMenuItem";
            this.verificarRegularidadeDoCondutorToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.verificarRegularidadeDoCondutorToolStripMenuItem.Text = "Verificar regularidade do condutor";
            this.verificarRegularidadeDoCondutorToolStripMenuItem.Click += new System.EventHandler(this.verificarRegularidadeDoCondutorToolStripMenuItem_Click);
            // 
            // condutorIrregularToolStripMenuItem
            // 
            this.condutorIrregularToolStripMenuItem.Name = "condutorIrregularToolStripMenuItem";
            this.condutorIrregularToolStripMenuItem.Size = new System.Drawing.Size(435, 22);
            this.condutorIrregularToolStripMenuItem.Text = "Mostrar o extrato de multas de um condutor.";
            this.condutorIrregularToolStripMenuItem.Click += new System.EventHandler(this.condutorIrregularToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 340);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 96);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Algoritmos e Estruturas de Dados Prof. João Caram                               A" +
    "laene Rufino de Sousa     Matrícula: 609992                             Sistemas" +
    " de Informação  --  2/2018";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TI_FINAL_AED.Properties.Resources.logotipo_TI;
            this.pictureBox1.Location = new System.Drawing.Point(48, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // taxasToolStripMenuItem
            // 
            this.taxasToolStripMenuItem.Name = "taxasToolStripMenuItem";
            this.taxasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taxasToolStripMenuItem.Text = "Taxas";
            this.taxasToolStripMenuItem.Click += new System.EventHandler(this.taxasToolStripMenuItem_Click);
            // 
            // Entrada
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(427, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosPorCondutorEMultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasPorVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosSemMultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condutorIrregularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMultasPorVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarRelatórioDeVeículosSemMultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarRegularidadeDoVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarRegularidadeDoCondutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem taxasToolStripMenuItem;
    }
}

