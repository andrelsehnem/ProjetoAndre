using Projeto_André.Classes;
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
        public Conexao infoBd = new Conexao();

        public frm_menuPrincipal(Conexao temp_banco)
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void logLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
