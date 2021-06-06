using Projeto_André.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_André.Forms
{
    public partial class frm_novoCliente : Form
    {
        public Conexao conex;
        public frm_novoCliente(Conexao temp_conex)
        {
            InitializeComponent();
            conex = temp_conex;
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            validaCPF();
        }

        private void check_funcionario_CheckedChanged(object sender, EventArgs e)
        {
            if (check_funcionario.Checked) group_funcionario.Enabled = true;
            else group_funcionario.Enabled = false;
        }

        private void txt_uf_Leave(object sender, EventArgs e)
        {
            txt_uf.Text.ToUpper();
        }
        
    }
}
