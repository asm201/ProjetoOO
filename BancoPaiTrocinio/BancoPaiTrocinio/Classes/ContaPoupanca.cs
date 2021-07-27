using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPaiTrocinio.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
        public int cp_id { get; set; }
        public int cp_id_conta_bancaria { get; set; }

        public int cp_nr_conta_poupanca { get; set; }
        public double cp_saldo { get; set; }

        public override void Depositar(double valor)
        {
            if (valor < 4000) {
                cp_saldo += valor;
                connect.ExecutaSQL($"UPDATE conta_poupanca SET cp_valor = {this.cp_saldo} WHERE cp_id = {this.cp_id}");
            } else {
                throw new ArgumentException("So pode ser depositado valores a baixo de R$4000.00");
            }
        }

        public override void Transferir(double valor, string conta)
        {
            if (conta.Length == 8)
            {
                if (valor < this.cp_saldo) { //busca pelo conta na tabela conta Corrente
                    this.cp_saldo -= valor;
                    //update na conta buscada
                    connect.ExecutaSQL($"UPDATE conta_poupanca SET cp_valor = {this.cp_saldo} WHERE cp_id = {this.cp_id}");
                    try {
                        DataTable query = connect.RetornaSQL($"SELECT cc.cc_id, cc.cc_saldo, u.u_nome FROM usuario u INNER JOIN cliente c ON u.u_id_cliente = c.c_id INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente INNER JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id WHERE cc.cc_nr_conta_corrente = {conta}");
                        double soma = Convert.ToDouble(query.Rows[0]["cc_saldo"]);
                        soma += valor;
                        connect.ExecutaSQL($"UPDATE conta_corrente SET cc_saldo = {soma} WHERE cc_id = {Convert.ToInt32(query.Rows[0]["cc_id"])}");
                        MessageBox.Show($"Transferência no valor de {valor} para {query.Rows[0]["u_nome"]} realizada com sucesso!");
                    } catch (Exception a) {
                        MessageBox.Show("Tranferência interbancária realizada com sucesso!");
                    }
                }
                else
                {
                    throw new ArgumentException("Saldo insuficiente para transação");
                }
            }
            if (conta.Length == 7)
            {
                if (valor < this.cp_saldo) {
                    if (valor < 10000) {
                        this.cp_saldo -= valor;
                        //update na conta buscada
                        connect.ExecutaSQL($"UPDATE conta_poupanca SET cp_valor = {this.cp_saldo} WHERE cc_id = {this.cp_id}");
                        DataTable query = connect.RetornaSQL($"SELECT cp.cp_id, cp.cp_valor, u.u_nome FROM usuario u INNER JOIN cliente c ON u.u_id_cliente = c.c_id INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente INNER JOIN conta_poupanca cp ON cb.cb_id_conta_corrente = cp.cp_id WHERE cp.cp_nr_conta_poupanca = {conta}");
                        double soma = Convert.ToDouble(query.Rows[0][1]);
                        soma += valor;
                        connect.ExecutaSQL($"UPDATE conta_poupanca SET cp_valor = {soma} WHERE cp_id = {Convert.ToInt32(query.Rows[0][0])}");
                        MessageBox.Show($"Transferência no valor de {valor} para {query.Rows[0][2]} realizada com sucesso!");
                    } else {
                        throw new ArgumentException("Transferencias para conta poupança tem limite de R$10000.00");
                    }
                } else {
                    throw new ArgumentException("Saldo insuficiente para transação");
                }
            }
        }
    }
}
