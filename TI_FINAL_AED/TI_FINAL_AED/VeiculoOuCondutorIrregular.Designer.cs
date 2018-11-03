namespace TI_FINAL_AED
{
    partial class VeiculoOuCondutorIrregular
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
            this.verificarPlacabyn = new System.Windows.Forms.Button();
            this.verificarCNHButton = new System.Windows.Forms.Button();
            this.placaRegularLabel = new System.Windows.Forms.Label();
            this.cnh = new System.Windows.Forms.Label();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnhMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // verificarPlacabyn
            // 
            this.verificarPlacabyn.Location = new System.Drawing.Point(182, 50);
            this.verificarPlacabyn.Name = "verificarPlacabyn";
            this.verificarPlacabyn.Size = new System.Drawing.Size(75, 23);
            this.verificarPlacabyn.TabIndex = 0;
            this.verificarPlacabyn.Text = "Verificar";
            this.verificarPlacabyn.UseVisualStyleBackColor = true;
            this.verificarPlacabyn.Click += new System.EventHandler(this.verificarPlacabyn_Click);
            // 
            // verificarCNHButton
            // 
            this.verificarCNHButton.Location = new System.Drawing.Point(182, 79);
            this.verificarCNHButton.Name = "verificarCNHButton";
            this.verificarCNHButton.Size = new System.Drawing.Size(75, 23);
            this.verificarCNHButton.TabIndex = 1;
            this.verificarCNHButton.Text = "Verificar";
            this.verificarCNHButton.UseVisualStyleBackColor = true;
            this.verificarCNHButton.Click += new System.EventHandler(this.verificarCNHButton_Click);
            // 
            // placaRegularLabel
            // 
            this.placaRegularLabel.AutoSize = true;
            this.placaRegularLabel.Location = new System.Drawing.Point(12, 56);
            this.placaRegularLabel.Name = "placaRegularLabel";
            this.placaRegularLabel.Size = new System.Drawing.Size(47, 13);
            this.placaRegularLabel.TabIndex = 2;
            this.placaRegularLabel.Text = "PLACA: ";
            // 
            // cnh
            // 
            this.cnh.AutoSize = true;
            this.cnh.Location = new System.Drawing.Point(12, 91);
            this.cnh.Name = "cnh";
            this.cnh.Size = new System.Drawing.Size(36, 13);
            this.cnh.TabIndex = 3;
            this.cnh.Text = "CNH: ";
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Location = new System.Drawing.Point(65, 53);
            this.placaMaskedTextBox.Mask = "aaa-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.placaMaskedTextBox.TabIndex = 4;
            // 
            // cnhMaskedTextBox
            // 
            this.cnhMaskedTextBox.Location = new System.Drawing.Point(65, 84);
            this.cnhMaskedTextBox.Mask = "00000000000";
            this.cnhMaskedTextBox.Name = "cnhMaskedTextBox";
            this.cnhMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnhMaskedTextBox.TabIndex = 5;
            // 
            // VeiculoOuCondutorIrregular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 152);
            this.Controls.Add(this.cnhMaskedTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.cnh);
            this.Controls.Add(this.placaRegularLabel);
            this.Controls.Add(this.verificarCNHButton);
            this.Controls.Add(this.verificarPlacabyn);
            this.Name = "VeiculoOuCondutorIrregular";
            this.Text = "VeiculoOuCondutorIrregular";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VeiculoOuCondutorIrregular_FormClosing);
            this.Load += new System.EventHandler(this.VeiculoOuCondutorIrregular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verificarPlacabyn;
        private System.Windows.Forms.Button verificarCNHButton;
        private System.Windows.Forms.Label placaRegularLabel;
        private System.Windows.Forms.Label cnh;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cnhMaskedTextBox;
    }
}