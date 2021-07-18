using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BancoPaiTrocinio.Conexões {
    class conexaoMySql {

        public static MySqlConnection conexao;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;

        public static void conectar() {
            conexao = new MySqlConnection("server=127.0.0.1;port=3306;database=banco_db;uid=root;pwd=;");
            try {
                conexao.Open();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public static void desconectar() {
            conexao.Close();
        }

        public Int32 executaSQL(string instrucaoSQL) {
            conectar();
            command = new MySqlCommand(instrucaoSQL, conexao);
            command.ExecuteNonQuery();
            desconectar();
            return 0;
        }

        public MySqlDataAdapter retornaSQL(string instrucaoSQL) {
            conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSQL, conexao);
            desconectar();
            return adapter;
        }
    }
}
