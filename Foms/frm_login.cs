using Projeto_André.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_André.Foms
{
    public partial class frm_login : Form
    {
        public Conexao conex = new Conexao();
        public String arquivoConfig = "config.txt";

        public frm_login()
        {
            InitializeComponent();
            conex.pcName = Environment.MachineName;
            getTxt();
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
            validaBanco();
            conex.Execute();
            conex.ConectaServer();
            conex.ComandoSql("use " + conex.banco);
            if (conex.conectado)
            {
                String comandoLogin = "insert into log_login (pc, usuario) VALUES('" + conex.pcName + "', '" + txt_userLogin.Text + "')";
                conex.ComandoSql(comandoLogin);
                frm_menuPrincipal frm = new frm_menuPrincipal(conex);
                frm.Show();
                conex.cnn.Close();
                this.Visible = false;
            }
        }

        private void bt_criaBd_Click(object sender, EventArgs e)
        {
            validaBanco();
            criarBanco();
        }

        private void criarBanco()
        {
            String cmd = "";
            conex.Execute();
            conex.ConectaServer();
            try
            {
                cmd = "CREATE DATABASE IF NOT EXISTS " + conex.banco;
                conex.ComandoSql(cmd);
                conex.ComandoSql("use " + conex.banco);
                criaTabelas();
            }
            catch
            {
                MessageBox.Show("Verifique os dados da conexão");
                return;
            }
            cmd = "insert into log_login (pc, usuario) VALUES('" + conex.pcName + "', '" + txt_userLogin.Text + "')";
            conex.ComandoSql(cmd);
        }

        private void criaTabelas()
        {
            //Tabela de log do login
            conex.ComandoSql("CREATE TABLE if not exists log_login (codigo int(4) not null AUTO_INCREMENT, data datetime default null,pc varchar(30) null default null collate 'utf8_general_ci', usuario VARCHAR(50) NOT NULL DEFAULT 'Usuario', PRIMARY KEY(codigo));");
            //trigger para inserir o horario que foi logado
            conex.ComandoSql("CREATE TRIGGER if not exists dataLogin BEFORE INSERT ON log_login FOR EACH ROW SET NEW.data = NOW()");
            //Tabela de usuarios
            conex.ComandoSql("create table if not exists usuarios (codigo int(4) not null auto_increment, user varchar(50) not null default 'user', senha varchar(20) not null default '', cancelado tinyint(1) null, PRIMARY KEY(codigo))");
            conex.ComandoSql("insert into usuarios (nome, senha) values ('user', '123')");
        }

        private void validaBanco()
        {
            conex.servidor = txt_servidor.Text;
            conex.porta = msk_porta.Text;
            conex.user = txt_usuarioServer.Text;
            conex.senha = msk_senhaServer.Text;
            conex.banco = txt_banco.Text;
        }

        private void getTxt()
        {
            String line;
            int cont = 1;
            try
            {
                if (System.IO.File.Exists(arquivoConfig))
                {
                    StreamReader sr = new StreamReader(arquivoConfig);
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        switch (cont)
                        {
                            case 1:
                                txt_servidor.Text = line;
                                break;
                            case 2:
                                msk_porta.Text = line;
                                break;
                            case 3:
                                txt_usuarioServer.Text = line;
                                break;
                            case 4:
                                msk_senhaServer.Text = line;
                                break;
                            case 5:
                                txt_banco.Text = line;
                                break;
                        }
                        cont++;
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Arquivo ''" + arquivoConfig + "'' não encontrado na pasta, configurações de conexão não serão salvas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            validaBanco();
            try
            {
                if (System.IO.File.Exists(arquivoConfig))
                {
                    StreamWriter sw = new StreamWriter(arquivoConfig);
                    sw.WriteLine(conex.servidor);
                    sw.WriteLine(conex.porta);
                    sw.WriteLine(conex.user);
                    sw.WriteLine(conex.senha);
                    sw.WriteLine(conex.banco);
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("Arquivo ''" + arquivoConfig + "'' não encontrado na pasta, configurações de conexão não serão salvas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
