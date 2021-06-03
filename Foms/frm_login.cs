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

namespace Projeto_André.Foms
{
    public partial class frm_login : Form
    {
        public Conexao infoBd = new Conexao();
        public frm_login()
        {
            InitializeComponent();
        }

        private void aba_login_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            fecharTela();
        }

        public void fecharTela()
        {
            Application.Exit();
        }

        private void frm_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(27))
            {
                fecharTela();
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            frm_menuPrincipal frm = new frm_menuPrincipal(infoBd);
            frm.Show();
        }

        private void bt_criaBd_Click(object sender, EventArgs e)
        {

        }

        private void criarBanco()
        {

        }

        private Boolean validaBanco()
        {

            return true;
        }

        private void salvaConfig()
        {

        }


    }
}
