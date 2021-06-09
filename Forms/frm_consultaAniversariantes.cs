using System;
using Projeto_André.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_André.Forms
{
    public partial class frm_consultaAniversariantes : Form
    {
        public Conexao conex;
        public frm_consultaAniversariantes(Conexao temp_conex)
        {
            InitializeComponent();
            conex = temp_conex;
        }

        private void frm_consultaAniversariantes_Load(object sender, EventArgs e)
        {

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            String periodo = "";
            String periodo1, periodo2;
            data_inicio.Format = DateTimePickerFormat.Custom;
            data_fim.Format = DateTimePickerFormat.Custom;
            periodo1 = data_inicio.Text;
            periodo2 = data_fim.Text;
            data_inicio.Format = DateTimePickerFormat.Short;
            data_fim.Format = DateTimePickerFormat.Short;
            periodo = "WHERE DATA between '" + periodo1 + " 00:00' AND '" + periodo2 + " 23:59' ";



            //setSelect(periodo, usuario);
        }
    }
}
