using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePOO
{
    public partial class Exibir_Menu : Form
    {
        public Exibir_Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create and initialize a Button.
            Button button1 = new Button();

            // Set the button to return a value of OK when clicked.
            button1.DialogResult = DialogResult.OK;

            // Add the button to the form.
            Controls.Add(button1);
        }

        private void Exibir_Menu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38,44,56);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
