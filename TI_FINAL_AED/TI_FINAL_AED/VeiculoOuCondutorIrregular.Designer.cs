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
            this.verificaCNHButton = new System.Windows.Forms.Button();
            this.verificaPlacaButton = new System.Windows.Forms.Button();
            this.placaRegularLabel = new System.Windows.Forms.Label();
            this.cnhRegularLabel = new System.Windows.Forms.Label();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnhMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // verificaCNHButton
            // 
            this.verificaCNHButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.verificaCNHButton.Location = new System.Drawing.Point(151, 145);
            this.verificaCNHButton.Name = "verificaCNHButton";
            this.verificaCNHButton.Size = new System.Drawing.Size(75, 33);
            this.verificaCNHButton.TabIndex = 0;
            this.verificaCNHButton.Text = "Verificar";
            this.verificaCNHButton.UseVisualStyleBackColor = true;
            this.verificaCNHButton.Visible = false;
            this.verificaCNHButton.Click += new System.EventHandler(this.verificaCNHButton_Click);
            // 
            // verificaPlacaButton
            // 
            this.verificaPlacaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.verificaPlacaButton.Location = new System.Drawing.Point(131, 84);
            this.verificaPlacaButton.Name = "verificaPlacaButton";
            this.verificaPlacaButton.Size = new System.Drawing.Size(75, 32);
            this.verificaPlacaButton.TabIndex = 1;
            this.verificaPlacaButton.Text = "Verificar";
            this.verificaPlacaButton.UseVisualStyleBackColor = true;
            this.verificaPlacaButton.Visible = false;
            this.verificaPlacaButton.Click += new System.EventHandler(this.verificaPlacaButton_Click);
            // 
            // placaRegularLabel
            // 
            this.placaRegularLabel.AutoSize = true;
            this.placaRegularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.placaRegularLabel.Location = new System.Drawing.Point(12, 61);
            this.placaRegularLabel.Name = "placaRegularLabel";
            this.placaRegularLabel.Size = new System.Drawing.Size(76, 20);
            this.placaRegularLabel.TabIndex = 2;
            this.placaRegularLabel.Text = "PLACA: ";
            this.placaRegularLabel.Visible = false;
            // 
            // cnhRegularLabel
            // 
            this.cnhRegularLabel.AutoSize = true;
            this.cnhRegularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cnhRegularLabel.Location = new System.Drawing.Point(12, 125);
            this.cnhRegularLabel.Name = "cnhRegularLabel";
            this.cnhRegularLabel.Size = new System.Drawing.Size(56, 20);
            this.cnhRegularLabel.TabIndex = 3;
            this.cnhRegularLabel.Text = "CNH: ";
            this.cnhRegularLabel.Visible = false;
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.placaMaskedTextBox.Location = new System.Drawing.Point(45, 84);
            this.placaMaskedTextBox.Mask = "aaa-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(80, 26);
            this.placaMaskedTextBox.TabIndex = 4;
            this.placaMaskedTextBox.Visible = false;
            this.placaMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.placaMaskedTextBox_MaskInputRejected);
            // 
            // cnhMaskedTextBox
            // 
            this.cnhMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cnhMaskedTextBox.Location = new System.Drawing.Point(45, 148);
            this.cnhMaskedTextBox.Mask = "00000000000";
            this.cnhMaskedTextBox.Name = "cnhMaskedTextBox";
            this.cnhMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.cnhMaskedTextBox.TabIndex = 5;
            this.cnhMaskedTextBox.Visible = false;
            this.cnhMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cnhMaskedTextBox_MaskInputRejected);
            // 
            // VeiculoOuCondutorIrregular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(427, 445);
            this.Controls.Add(this.cnhMaskedTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.cnhRegularLabel);
            this.Controls.Add(this.placaRegularLabel);
            this.Controls.Add(this.verificaPlacaButton);
            this.Controls.Add(this.verificaCNHButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VeiculoOuCondutorIrregular";
            this.Text = "VeiculoOuCondutorIrregular";
            this.Load += new System.EventHandler(this.VeiculoOuCondutorIrregular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verificaCNHButton;
        private System.Windows.Forms.Button verificaPlacaButton;
        private System.Windows.Forms.Label placaRegularLabel;
        private System.Windows.Forms.Label cnhRegularLabel;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cnhMaskedTextBox;
    }
}