namespace TI_FINAL_AED
{
    partial class ExtratoDeMultasDeUmCondutor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cnhExtratoLabel = new System.Windows.Forms.Label();
            this.cnhExtratoMaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.listarExtratoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(28, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 383);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // cnhExtratoLabel
            // 
            this.cnhExtratoLabel.AutoSize = true;
            this.cnhExtratoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnhExtratoLabel.Location = new System.Drawing.Point(24, 21);
            this.cnhExtratoLabel.Name = "cnhExtratoLabel";
            this.cnhExtratoLabel.Size = new System.Drawing.Size(56, 20);
            this.cnhExtratoLabel.TabIndex = 2;
            this.cnhExtratoLabel.Text = "CNH: ";
            // 
            // cnhExtratoMaskTextBox
            // 
            this.cnhExtratoMaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnhExtratoMaskTextBox.Location = new System.Drawing.Point(76, 15);
            this.cnhExtratoMaskTextBox.Mask = "00000000000";
            this.cnhExtratoMaskTextBox.Name = "cnhExtratoMaskTextBox";
            this.cnhExtratoMaskTextBox.Size = new System.Drawing.Size(114, 26);
            this.cnhExtratoMaskTextBox.TabIndex = 5;
            // 
            // listarExtratoButton
            // 
            this.listarExtratoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarExtratoButton.Location = new System.Drawing.Point(196, 15);
            this.listarExtratoButton.Name = "listarExtratoButton";
            this.listarExtratoButton.Size = new System.Drawing.Size(75, 26);
            this.listarExtratoButton.TabIndex = 6;
            this.listarExtratoButton.Text = "Listar";
            this.listarExtratoButton.UseVisualStyleBackColor = true;
            this.listarExtratoButton.Click += new System.EventHandler(this.listarExtratoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExtratoDeMultasDeUmCondutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(427, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listarExtratoButton);
            this.Controls.Add(this.cnhExtratoMaskTextBox);
            this.Controls.Add(this.cnhExtratoLabel);
            this.Controls.Add(this.listView1);
            this.Name = "ExtratoDeMultasDeUmCondutor";
            this.Text = "ExtratoDeMultasDeUmCondutor";
            this.Load += new System.EventHandler(this.ExtratoDeMultasDeUmCondutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label cnhExtratoLabel;
        private System.Windows.Forms.MaskedTextBox cnhExtratoMaskTextBox;
        private System.Windows.Forms.Button listarExtratoButton;
        private System.Windows.Forms.Label label1;
    }
}