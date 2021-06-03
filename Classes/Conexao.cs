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
                MessageBox.Show("Conexão não estabelecida, verifique as informações inseridas");
                conectado = false;
                MessageBox.Show(ex.ToString());
                return;
            }
            conectado = true;
        }

        private Boolean colunaExiste(String tabela, String coluna)
        {

            //essa função vai retornar se a coluna existe nesta tabela
            ComandoSql("SELECT * FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + banco + "' AND TABLE_NAME = '" + tabela + "' AND COLUMN_NAME = '" + coluna + "'");
            try
            {
                cnn.Open();
                reader = comandoProSql.ExecuteReader();
                reader.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return reader.HasRows; //se existir retorna TRUE
        }
    }
}
