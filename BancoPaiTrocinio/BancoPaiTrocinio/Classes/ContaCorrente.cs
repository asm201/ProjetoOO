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
        private double _saldo = 100;
        public double cc_saldo
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

        }

        public override void Transferir(double valor)
        {

        }
    }

}
