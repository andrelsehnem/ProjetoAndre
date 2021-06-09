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
using MySql.Data.MySqlClient;

namespace Projeto_André.Forms
{
    public partial class frm_loglogin : Form
    {
        public Conexao conex;
        public String selectCliente = "select data as Data, pc as Terminal, usuario as Usuário from log_login ";
        public MySqlDataReader reader;
        public MySqlDataAdapter da;
        public DataSet ds = new DataSet();

        public frm_loglogin(Conexao temp_conex)
        {
            InitializeComponent();
            conex = temp_conex;
            usuariosComboBox();
        }

        private void usuariosComboBox()
        {
            try
            {
                conex.ComandoSql("SELECT user FROM usuarios WHERE cancelado IS null group by user");
                conex.cnn.Open();
                reader = conex.comandoProSql.ExecuteReader();
                reader.Read();
                while (reader.HasRows)
                {
                    
                    combo_usuarios.Items.Add(reader.GetString(0));
                    reader.NextResult();

                }
                conex.cnn.Close();
                reader.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            String periodo = "", usuario = "";
            String periodo1, periodo2;
            data_periodo1.Format = DateTimePickerFormat.Custom;
            data_periodo2.Format = DateTimePickerFormat.Custom;
            periodo1 = data_periodo1.Text;
            periodo2 = data_periodo2.Text;
            data_periodo1.Format = DateTimePickerFormat.Short;
            data_periodo2.Format = DateTimePickerFormat.Short;
            periodo = "WHERE DATA between '"+periodo1+" 00:00' AND '"+periodo2+" 23:59' ";

            if (combo_usuarios.Text == "Todos")
            {
                usuario = "";
            }
            else
            {
                usuario = "and usuario = '" + combo_usuarios.Text + "'";
            }

            setSelect(periodo, usuario);
        }

        private void listarGrid(String cmd)
        {
            
            try
            {
                conex.cnn.Open();
                conex.ComandoSql(cmd);
                da = new MySqlDataAdapter(conex.comandoProSql);
                ds = new DataSet();
                da.Fill(ds);
                grid_login.DataSource = ds;
                grid_login.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conex.cnn.Close();
            }

            //grid_login.Columns[0].Width = 35;
            grid_login.Refresh();
        }

        private void setSelect(String periodo, String usuario)
        {
            String temp_cmd = "select data as Data, pc as Terminal, usuario as Usuário from log_login ";
            
            selectCliente = temp_cmd + periodo + usuario;
            listarGrid(selectCliente);
        }

        private void frm_loglogin_Load(object sender, EventArgs e)
        {

        }

        private void combo_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
