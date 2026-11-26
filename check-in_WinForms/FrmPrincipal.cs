using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_in_WinForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro formulario = new FrmCadastro();

            formulario.MdiParent = this;

            formulario.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem formulario = new FrmListagem();

            formulario.MdiParent = this;

            formulario.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCadastro formulario = new FrmCadastro();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void listagemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
