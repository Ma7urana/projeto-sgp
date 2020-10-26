using System.Drawing;

namespace AtividadePOO
{
    partial class Exibir_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Controle_Cadastro_Gerais = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(74, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Caixa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Controle Cadastro Gerais
            // 
            this.Controle_Cadastro_Gerais.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controle_Cadastro_Gerais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Controle_Cadastro_Gerais.Location = new System.Drawing.Point(74, 154);
            this.Controle_Cadastro_Gerais.Name = "button2";
            this.Controle_Cadastro_Gerais.Size = new System.Drawing.Size(171, 37);
            this.Controle_Cadastro_Gerais.TabIndex = 1;
            this.Controle_Cadastro_Gerais.Text = "Controle Cadastros Gerais";
            this.Controle_Cadastro_Gerais.UseVisualStyleBackColor = false;
            this.Controle_Cadastro_Gerais.Click += new System.EventHandler(this.Controle_Cadastro_Gerais_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(74, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Controle de Vendas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(74, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Controle Geral de Compras";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(361, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Controle Geral de Relatórios";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(361, 154);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "Controle de Contas a pagar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(364, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "Controle de Caixa Sebrae";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(364, 270);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 35);
            this.button8.TabIndex = 7;
            this.button8.Text = "Dashboard de Fluxo de Caixa";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "SGP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(9, 14);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 33);
            this.button9.TabIndex = 9;
            this.button9.Text = "Cadastre-se";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Login
            // 
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(458, 16);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(101, 31);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.BackColor = Color.FromArgb(190, 188, 189);
            

            // 
            // Exibir_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(582, 361);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Controle_Cadastro_Gerais);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Name = "Exibir_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Exibir_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Controle_Cadastro_Gerais;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Login;
    }
}

