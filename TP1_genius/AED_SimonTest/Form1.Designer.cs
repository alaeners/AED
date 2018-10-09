namespace AED_SimonTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.CheckBox();
            this.btnAmarelo = new System.Windows.Forms.CheckBox();
            this.btnVermelho = new System.Windows.Forms.CheckBox();
            this.btnVerde = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTeste
            // 
            this.btnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeste.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.ForeColor = System.Drawing.Color.LightCoral;
            this.btnTeste.Location = new System.Drawing.Point(168, 299);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(365, 44);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "TESTE";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.LightCoral;
            this.btnSair.Location = new System.Drawing.Point(168, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(365, 44);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Enabled = false;
            this.btnAzul.FlatAppearance.BorderSize = 10;
            this.btnAzul.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzul.Location = new System.Drawing.Point(526, 147);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(147, 130);
            this.btnAzul.TabIndex = 9;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.Enabled = false;
            this.btnAmarelo.FlatAppearance.BorderSize = 10;
            this.btnAmarelo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.btnAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmarelo.Location = new System.Drawing.Point(386, 147);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(147, 130);
            this.btnAmarelo.TabIndex = 8;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnVermelho
            // 
            this.btnVermelho.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnVermelho.BackColor = System.Drawing.Color.Red;
            this.btnVermelho.Enabled = false;
            this.btnVermelho.FlatAppearance.BorderSize = 10;
            this.btnVermelho.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVermelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVermelho.Location = new System.Drawing.Point(526, 24);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(147, 130);
            this.btnVermelho.TabIndex = 7;
            this.btnVermelho.UseVisualStyleBackColor = false;
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Enabled = false;
            this.btnVerde.FlatAppearance.BorderSize = 10;
            this.btnVerde.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Location = new System.Drawing.Point(386, 24);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(147, 130);
            this.btnVerde.TabIndex = 6;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(712, 405);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTeste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AEDSimonPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.btnTeste, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnVerde, 0);
            this.Controls.SetChildIndex(this.btnVermelho, 0);
            this.Controls.SetChildIndex(this.btnAmarelo, 0);
            this.Controls.SetChildIndex(this.btnAzul, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox btnAzul;
        private System.Windows.Forms.CheckBox btnAmarelo;
        private System.Windows.Forms.CheckBox btnVermelho;
        private System.Windows.Forms.CheckBox btnVerde;
    }
}

