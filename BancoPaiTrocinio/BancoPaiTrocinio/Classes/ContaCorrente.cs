using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public int cc_id { get; set; }
        public int cc_id_conta_bancaria { get; set; }

        public int cc_nr_conta_corrente { get; set; }
        public double cc_saldo { get; set; }

        public override void Depositar(double valor)
        {
            if (valor > 10000)
                this.cc_saldo += valor;
            else
                throw new ArgumentException("Só pode ser depositado valores a baixo de R$10000.00");
        }

        public override void Transferir(double valor, string conta)
        {
            if (conta.Length == 8)
            {
                if(valor > this.cc_saldo)
                {
                    //busca pelo conta na tabela conta Corrente
                    this.cc_saldo -= valor;
                    //update na conta buscada
                }
                else
                {
                    throw new ArgumentException("Saldo insuficiente para transação");
                }
            }
            if(conta.Length == 7)
            {
                if (valor > this.cc_saldo)
                {
                    if(valor < 4000)
                    {
                        //busca pelo conta na tabela conta poupança
                        this.cc_saldo -= valor;
                        //update na conta buscada
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
