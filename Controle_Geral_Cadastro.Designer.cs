namespace AtividadePOO
{
    partial class Controle_Geral_Cadastro
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
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Location = new System.Drawing.Point(107, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 34);
            this.button4.TabIndex = 0;
            this.button4.Text = "Cadastrar Usuário no SIstema";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button6.Location = new System.Drawing.Point(108, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 36);
            this.button6.TabIndex = 2;
            this.button6.Text = "Cadastrar Cliente";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Location = new System.Drawing.Point(108, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 36);
            this.button5.TabIndex = 1;
            this.button5.Text = "Cadastrar Funcionário";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle Cadastros Gerais";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(109, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar Produto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Controle_Geral_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(411, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Name = "Controle_Geral_Cadastro";
            this.Text = "Controle Geral de Cadastro";
            this.Load += new System.EventHandler(this.Controle_Geral_Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}