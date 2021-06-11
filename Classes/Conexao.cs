using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_André.Classes
{
    public class Conexao
    {
        public String servidor = "localhost";
        public String porta = "3306";
        public String user = "root";
        public String senha = "admin";
        public String banco = "bancoProjeto";
        public String pcName = "";
        public String userLogin = "";
        public String senhaLogin = "";
        public String comando = "";
        public MySqlConnection cnn = new MySqlConnection();
        public MySqlCommand comandoProSql = new MySqlCommand();
        public MySqlDataReader reader;
        public Boolean conectado = false;
        // compile with: /reference:cs0012b.dll  


        public void Execute()
        {
            comandoProSql.Connection = cnn;
            comandoProSql.CommandType = CommandType.Text;

        }
        public void ComandoSql(String cmd)
        {
            cnn.Close();
            comandoProSql.CommandText = cmd;
            try
            {
                cnn.Open();
                comandoProSql.ExecuteNonQuery();
                cnn.Close();
                conectado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conectado = false;

            }
        }

        public void ConectaServer()
        {
            try
            {
                cnn.ConnectionString = "server=" + servidor + ";Port=" + porta + ";uid=" + user + ";pwd=" + senha + ";SslMode=none";
                cnn.Open();
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show("Conexão não estabelecida, verifique as informações inseridas");
                conectado = false;
                MessageBox.Show(ex.ToString());
                return;
            }
            conectado = true;
        }

        public Boolean validaTabela(String cmd)
        {
            //essa função vai retornar se a coluna existe nesta tabela
            ComandoSql(cmd);
            try
            {
                cnn.Open();
                reader = comandoProSql.ExecuteReader();
                reader.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cnn.Close();

            }

            return reader.HasRows; //se existir retorna TRUE
        }
    }
}
