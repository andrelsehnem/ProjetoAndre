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
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Insira um nome.");
                return;
            }
            if (!validaCPF(msk_cpf.Text))
            {
                MessageBox.Show("Informe um CPF válido!");
                return;
            }
            
            //if cpf já cadastrado

            if (check_funcionario.Checked)
            {
                if (txt_usuario.Text == "" || txt_senha.Text == "")
                {
                    MessageBox.Show("Selecionado para ser funcionário, necessário informar usuário e senha válidos");
                }
            }

            //if funcionário já existe
            MessageBox.Show("insert into clientes (nome, cpf, nascimento, funcionario, funcionarioUser, cancelado, endereco, numero, complemento, bairro, cidade, estado, telefone) values ('" + txt_nome.Text + "', '" + msk_cpf.Text + "', " + msk_nascimento.Text + ", " + check_funcionario.Checked + ", '" + txt_usuario.Text + "', " + 0 + ",'" + txt_endereco.Text + "'," + Convert.ToInt32(msk_numero.Text) + ",'" + txt_complemento.Text + "',' " + txt_bairro.Text + "','" + txt_cidade.Text + "','" + txt_uf.Text + "','" + msk_telefone.Text + "'");

            //conex.ComandoSql("insert into clientes (nome, cpf, nascimento, funcionario, funcionarioUser, cancelado, endereco, numero, complemento, bairro, cidade, estado, telefone) values ('" + txt_nome.Text + "', '" + msk_cpf.Text + "', " + Convert.ToDateTime(msk_nascimento.Text) + ", " + check_funcionario.Checked + ", '"+ txt_usuario.Text + "', " + 0 + ",'"+ txt_endereco.Text + "'," + Convert.ToInt32(msk_numero.Text) + ",'" + txt_complemento.Text + "',' " + txt_bairro.Text + "','" + txt_cidade.Text + "','"+ txt_uf.Text + "','" + msk_telefone.Text + "'" );
            
            //insert into TABELA (campos) values (valores)
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
    }
}
