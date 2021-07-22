using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BancoPaiTrocinio.Conexões {
    class ConexaoMySql
    {

        public static MySqlConnection conexao;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;

        public static void Conectar()
        {
            conexao = new MySqlConnection("server=127.0.0.1;port=3306;database=banco_db;uid=root;pwd=;");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public static void Desconectar()
        {
            conexao.Close();
        }

        public int ExecutaSQL(string instrucaoSQL)
        {
            Conectar();
            command = new MySqlCommand(instrucaoSQL, conexao);
            command.ExecuteNonQuery();
            Desconectar();
            return 1;
        }

        public DataTable RetornaSQL(string instrucaoSQL)
        {
            Conectar();
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSQL, conexao)) {
                adapter.Fill(dt);
            }
            Desconectar();
            return dt;
        }
    }
}
