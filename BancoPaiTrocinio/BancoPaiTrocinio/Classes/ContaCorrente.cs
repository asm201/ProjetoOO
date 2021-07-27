using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPaiTrocinio.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        Conexões.ConexaoMySql connect = new Conexões.ConexaoMySql();
        public int cc_id { get; set; }
        public int cc_id_conta_bancaria { get; set; }

        public int cc_nr_conta_corrente { get; set; }
        public double cc_saldo { get; set; }

        public override void Depositar(double valor)
        {
            if (valor < 10000) {
                this.cc_saldo += valor;
                connect.ExecutaSQL($"UPDATE conta_corrente SET cc_saldo = {this.cc_saldo} WHERE cc_id = {this.cc_id}");
            } else {
                throw new ArgumentException("Só pode ser depositado valores a baixo de R$10000.00");
            }
        }

        public override void Transferir(double valor, string conta)
        {
            if (conta.Length == 8)
            {
                if(valor < this.cc_saldo)
                {
                    //busca pelo conta na tabela conta Corrente
                    this.cc_saldo -= valor;
                    //update na conta buscada
                    connect.ExecutaSQL($"UPDATE conta_corrente SET cc_saldo = {this.cc_saldo} WHERE cc_id = {this.cc_id}");
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
            if(conta.Length == 7)
            {
                if (valor < this.cc_saldo)
                {
                    if(valor < 4000)
                    {
                        try {
                            this.cc_saldo -= valor;
                            //update na conta buscada
                            connect.ExecutaSQL($"UPDATE conta_corrente SET cc_saldo = {this.cc_saldo} WHERE cc_id = {this.cc_id}");
                            DataTable query = connect.RetornaSQL($"SELECT cp.cp_id, cp.cp_valor, u.u_nome FROM usuario u INNER JOIN cliente c ON u.u_id_cliente = c.c_id INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente INNER JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id WHERE cp.cp_nr_conta_poupanca = {conta}");
                            double soma = Convert.ToDouble(query.Rows[0][1]);
                            soma += valor;
                            connect.ExecutaSQL($"UPDATE conta_poupanca SET cp_valor = {soma} WHERE cp_id = {Convert.ToInt32(query.Rows[0][0])}");
                            MessageBox.Show($"Transferência no valor de {valor} para {query.Rows[0][2]} realizada com sucesso!");
                        } catch (Exception a) {
                            MessageBox.Show("Tranferência interbancária realizada com sucesso!");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Transferencias para conta poupança tem limite de R$4000.00");
                    }
                }
                else
                {
                    throw new ArgumentException("Saldo insuficiente para transação");
                }
            }
        }
    }

}
