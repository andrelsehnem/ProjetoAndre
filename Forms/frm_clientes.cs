using MySql.Data.MySqlClient;
using Projeto_André.Classes;
using Projeto_André.Forms;
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
    public partial class frm_clientes : Form
    {
        public Conexao conex;
        public MySqlDataReader reader;
        public String selectCliente = "select codigo as Cod, nome as Nome, cpf as CPF from clientes where cancelado is null ";


        public frm_clientes(Conexao temp_conex)
        {
            InitializeComponent();
            conex = temp_conex;
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {
            updateGrid(selectCliente);
        }

        private void updateGrid(String cmd)
        {//receber uma string de comando sql
            conex.cnn.Open();
            conex.ComandoSql(cmd);
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(conex.comandoProSql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grid_clientes.DataSource = ds;
                grid_clientes.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conex.cnn.Close();
            }

            grid_clientes.Columns[0].Width = 35;
            grid_clientes.Refresh();

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            String pesquisa = "", tipo = "";

            if (combo_tipo.Text == "Cliente") tipo = " and funcionario is null ";
            else if (combo_tipo.Text == "Funcionário") tipo = " and funcionario = 1 ";
            else tipo = "";

            if (txt_pesquisa.Text == "") pesquisa = "";
            else if (combo_pesquisa.Text == "Código") pesquisa = "and codigo like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "Nome") pesquisa = "and nome like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "CPF") pesquisa = "and cpf like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "Telefone") pesquisa = "and telefone like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "Endereço") pesquisa = "and endereco like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "Complemento") pesquisa = "and complemento like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "Bairro") pesquisa = "and bairro like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "Cidade") pesquisa = "and cidade like '%" + txt_pesquisa.Text + "%' ";
            else if (combo_pesquisa.Text == "Estado") pesquisa = "and estado like '%" + txt_pesquisa.Text + "%' ";
            else pesquisa = "";

            setSelect(pesquisa, tipo);
        }

        private void setSelect(String pesquisa, string tipo)
        {
            String temp_cmd = "select codigo as Cod, nome as Nome, cpf as CPF from clientes where cancelado is null ";
            if (tipo != "")
            {
                temp_cmd = temp_cmd + tipo;
            }
            if (pesquisa != "")
            {
                temp_cmd = temp_cmd + pesquisa;
            }

            selectCliente = temp_cmd;
            updateGrid(selectCliente);
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            frm_novoCliente frm = new frm_novoCliente(conex);
            frm.Show();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            String campo = "";
            var teste = grid_clientes.CurrentCell.EditedFormattedValue; //pega o valor da celular
            var teste2 = grid_clientes.CurrentCell;
            MessageBox.Show(teste2.OwningColumn.Name);
            // if o de cima = nome busca pelo nome e altera pra cancelado depois de confirmar
            //if codigo busca pelo codigo, etc
           
            conex.ComandoSql("select * from clientes where " + campo + " = " + teste );
            conex.cnn.Open();
            reader = conex.comandoProSql.ExecuteReader();
            reader.Read();
            reader.Close();
        }
    }
}

