namespace TI_FINAL_AED
{
    partial class ListarMultasPorVeiculo
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
            this.placaLabel = new System.Windows.Forms.Label();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.multasPorVeiculoListView = new System.Windows.Forms.ListView();
            this.listaMultaPorVeiculoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placaLabel
            // 
            this.placaLabel.AutoSize = true;
            this.placaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaLabel.Location = new System.Drawing.Point(44, 21);
            this.placaLabel.Name = "placaLabel";
            this.placaLabel.Size = new System.Drawing.Size(76, 20);
            this.placaLabel.TabIndex = 0;
            this.placaLabel.Text = "PLACA: ";
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaMaskedTextBox.Location = new System.Drawing.Point(126, 15);
            this.placaMaskedTextBox.Mask = "AAA-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(76, 26);
            this.placaMaskedTextBox.TabIndex = 1;
            // 
            // multasPorVeiculoListView
            // 
            this.multasPorVeiculoListView.Location = new System.Drawing.Point(27, 56);
            this.multasPorVeiculoListView.Name = "multasPorVeiculoListView";
            this.multasPorVeiculoListView.Size = new System.Drawing.Size(373, 382);
            this.multasPorVeiculoListView.TabIndex = 2;
            this.multasPorVeiculoListView.UseCompatibleStateImageBehavior = false;
            // 
            // listaMultaPorVeiculoButton
            // 
            this.listaMultaPorVeiculoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaMultaPorVeiculoButton.Location = new System.Drawing.Point(208, 15);
            this.listaMultaPorVeiculoButton.Name = "listaMultaPorVeiculoButton";
            this.listaMultaPorVeiculoButton.Size = new System.Drawing.Size(100, 28);
            this.listaMultaPorVeiculoButton.TabIndex = 3;
            this.listaMultaPorVeiculoButton.Text = "Buscar";
            this.listaMultaPorVeiculoButton.UseVisualStyleBackColor = true;
            this.listaMultaPorVeiculoButton.Click += new System.EventHandler(this.listaMultaPorVeiculoButton_Click);
            // 
            // ListarMultasPorVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(427, 445);
            this.Controls.Add(this.listaMultaPorVeiculoButton);
            this.Controls.Add(this.multasPorVeiculoListView);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.placaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarMultasPorVeiculo";
            this.Text = "ListarMultasPorVeiculo";
            this.Load += new System.EventHandler(this.ListarMultasPorVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placaLabel;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.ListView multasPorVeiculoListView;
        private System.Windows.Forms.Button listaMultaPorVeiculoButton;
    }
}