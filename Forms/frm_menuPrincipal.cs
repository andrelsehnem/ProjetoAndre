using Projeto_André.Classes;
using Projeto_André.Foms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_André
{
    public partial class frm_menuPrincipal : Form
    {
        public Conexao conex = new Conexao();

        public frm_menuPrincipal(Conexao temp_banco)
        {
            InitializeComponent();
            conex = temp_banco;
        }

        private void frm_menuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_clientes frm = new frm_clientes(conex);
            frm.Show();
        }

        private void frm_menuPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                MessageBox.Show("Você pressionou o F3.");
            }
        }
    }
}
