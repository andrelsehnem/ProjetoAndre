using MySql.Data.MySqlClient;
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
        public MySqlDataReader reader;
        public frm_novoCliente(Conexao temp_conex)
        {
            InitializeComponent();
            conex = temp_conex;
            try
            {
                conex.ComandoSql("select codigo from clientes order by codigo desc limit 1");
                conex.cnn.Open();
                reader = conex.comandoProSql.ExecuteReader();
                reader.Read();
                int codigo = 1;
                if (reader.HasRows) codigo = Convert.ToInt32(reader.GetString(0)) + 1;
                reader.Close();
                txt_codigo.Text = " " + codigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            String camposSql = "";
            String valoresSql = "";
            String insertFuncionario = "";
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Insira um nome.");
                return;
            }
            else
            {
                camposSql = "nome";
                valoresSql = "'" + txt_nome.Text + "'";
            }
            if (!validaCPF(msk_cpf.Text))
            {
                MessageBox.Show("Informe um CPF válido!");
                return;
            }
            conex.ComandoSql("select codigo from clientes where cpf = '" + msk_cpf.Text + "'");
            conex.cnn.Open();
            reader = conex.comandoProSql.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                MessageBox.Show("Este CPF já está cadastrado.");
                return;
            }
            else
            {
                camposSql = camposSql + ",cpf";
                valoresSql = valoresSql +  ",'" +  msk_cpf.Text + "'";
            }
            reader.Close();
            if (data_nascimento.Checked)
            {
                data_nascimento.Format = DateTimePickerFormat.Custom;
                String data = data_nascimento.Text;
                data_nascimento.Format = DateTimePickerFormat.Short;
                camposSql = camposSql + ",nascimento";
                valoresSql = valoresSql + ",'" + data + "'";
            }
            if (check_funcionario.Checked)
            {
                if (txt_usuario.Text == "" || txt_senha.Text == "")
                {
                    MessageBox.Show("Selecionado para ser funcionário, necessário informar usuário e senha válidos");
                    return;
                }
                conex.ComandoSql("select codigo from usuarios where user = '" + txt_usuario.Text + "'");
                conex.cnn.Open();
                reader = conex.comandoProSql.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    MessageBox.Show("Username já cadastrado, informe outro.");
                    return;
                }
                reader.Close();
                camposSql = camposSql + "',funcionario, funcionarioUser'";
                valoresSql = valoresSql + ", 1, '" + txt_usuario.Text + "'"; 
                insertFuncionario = "insert into usuarios (user,senha,codigoCliente) values ('" + txt_usuario.Text + "','" + txt_senha.Text + "'," + txt_codigo.Text + ")";
            }
            if (txt_endereco.Text != "")
            {
                camposSql = camposSql + ",endereco";
                valoresSql = valoresSql + ",'" + txt_endereco.Text + "'";
            }
            if (msk_numero.Text != "")
            {
                camposSql = camposSql + ",numero";
                valoresSql = valoresSql + "," + Convert.ToInt32(msk_numero.Text);
            }
            if (txt_complemento.Text != "")
            {
                camposSql = camposSql + ",complemento";
                valoresSql = valoresSql + ",'" + txt_complemento.Text +"'";
            }
            if (txt_bairro.Text != "")
            {
                camposSql = camposSql + ",bairro";
                valoresSql = valoresSql + ",'" + txt_bairro.Text + "'";
            }
            if (txt_cidade.Text != "")
            {
                camposSql = camposSql + ",cidade";
                valoresSql = valoresSql + ",'" + txt_cidade.Text + "'";
            }
            if (txt_uf.Text != "")
            {
                camposSql = camposSql + ",uf";
                valoresSql = valoresSql + ",'" + txt_uf.Text + "'";
            }
            if (msk_telefone.Text != "(  )      -")
            {
                camposSql = camposSql + ",telefone";
                valoresSql = valoresSql + ",'" + msk_telefone.Text + "'";
            }
            
            conex.ComandoSql("insert into clientes (" + camposSql + ") values (" + valoresSql + ")");
            if (check_funcionario.Checked) conex.ComandoSql(insertFuncionario);
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
       

        public bool validaCPF(string CPFtest)
        { //SE RETORNAR TRUE É CPF VALIDO
            if (CPFtest == "")
                return false;
            string cpf = CPFtest;

            int d1, d2;
            int soma = 0;
            string digitado = "";
            string calculado = "";

            // Pesos para calcular o primeiro digito
            int[] peso1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            // Pesos para calcular o segundo digito
            int[] peso2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] n = new int[11];

            // Se o tamanho for < 11 entao retorna como inválido
            if (cpf.Length != 11)
                return false;
            try
            {
                // Quebra cada digito do CPF
                int contTrue = 0;
                for (int nu = 0; nu < 11; nu++)
                {
                    n[nu] = Convert.ToInt32(cpf.Substring(nu, 1));
                    if (nu > 0 && n[nu] == n[nu - 1])
                    { //validar se todos os numeors são iguais pt1
                        contTrue++;
                    }
                }
                if (contTrue >= 10)
                { //validar se todos os numeros sao igais pt2
                    return false;
                }
            }
            catch
            {
                return false;
            }
            // Calcula cada digito com seu respectivo peso
            for (int i = 0; i <= peso1.GetUpperBound(0); i++)
                soma += (peso1[i] * Convert.ToInt32(n[i]));
            // Pega o resto da divisao
            int resto = soma % 11;

            if (resto == 1 || resto == 0)
                d1 = 0;
            else
                d1 = 11 - resto;

            soma = 0;
            // Calcula cada digito com seu respectivo peso
            for (int i = 0; i <= peso2.GetUpperBound(0); i++)
                soma += (peso2[i] * Convert.ToInt32(n[i]));
            // Pega o resto da divisao
            resto = soma % 11;
            if (resto == 1 || resto == 0)
                d2 = 0;
            else
                d2 = 11 - resto;
            calculado = d1.ToString() + d2.ToString();
            digitado = n[9].ToString() + n[10].ToString();
            // Se os ultimos dois digitos calculados bater com
            // os dois ultimos digitos do cpf entao é válido
            if (calculado == digitado)
                return (true);
            else
                return (false);
        }

        private void frm_novoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
