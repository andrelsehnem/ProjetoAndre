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
        public String comando = "";
        public MySqlConnection cnn = new MySqlConnection();
        public MySqlCommand comandoProSql = new MySqlCommand();
        public MySqlDataReader reader;
        public Boolean conectado = false;


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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ConectaBanco()
        {
            try
            {
                cnn.ConnectionString = "server=" + servidor + ";Port=" + porta + ";uid=" + user + ";pwd=" + senha + ";SslMode=none";
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexão não estabelecida, verifique as informações inseridas");
                conectado = false;
                MessageBox.Show(ex.ToString());
                return;
            }
            conectado = true;
        }
    }
}
