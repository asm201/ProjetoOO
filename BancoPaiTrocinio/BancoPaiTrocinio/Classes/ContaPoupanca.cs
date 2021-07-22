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
        private double _saldo = 100;
        public double cp_saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public override void Depositar(double valor)
        {   
            if(valor > 10000)
                _saldo += valor;
            else
                throw new ArgumentException("So pode ser depositado valores a baixo de R$10000.00");
        }

        public override void Transferir(double valor)
        {

        }
    }
}
