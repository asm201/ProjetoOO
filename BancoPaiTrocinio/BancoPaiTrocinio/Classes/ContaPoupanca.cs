using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public int cp_id { get; set; }
        public int cp_id_conta_bancaria { get; set; }

        public int cp_nr_conta_poupanca { get; set; }
        public double cp_saldo { get; set; }

        public override void Depositar(double valor)
        {   
            if(valor > 4000)
               cp_saldo += valor;
            else
                throw new ArgumentException("So pode ser depositado valores a baixo de R$4000.00");
        }

        public override void Transferir(double valor, string conta)
        {
            if (conta.Length == 8)
            {
                if (valor > this.cp_saldo)
                {
                    if (valor < 4000)
                    {
                        //busca pelo conta na tabela conta poupança
                        this.cp_saldo -= valor;
                        //update na conta buscada
                    }
                    else
                    {
                        throw new ArgumentException("Transferencias para conta corrente tem limite de R$4000.00");
                    }
                }
                else
                {
                    throw new ArgumentException("Saldo insuficiente para transação");
                }
            }
            if (conta.Length == 7)
            {
                if (valor > this.cp_saldo)
                {
                    if (valor < 10000)
                    {
                        //busca pelo conta na tabela conta poupança
                        this.cp_saldo -= valor;
                        //update na conta buscada
                    }
                    else
                    {
                        throw new ArgumentException("Transferencias para conta poupança tem limite de R$10000.00");
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
