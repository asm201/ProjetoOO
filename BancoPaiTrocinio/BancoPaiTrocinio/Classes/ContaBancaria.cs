using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    public abstract class ContaBancaria : Cliente
    {
        public int cb_id { get; set; }
        public int cb_agencia { get; set; }
        public int cb_id_cliente { get; set; }

        public int cb_id_conta_corrente { get; set; }

        public int cb_id_conta_poupanca { get; set; }

        public abstract void Depositar(double valor);

        public abstract void Transferir(double valor, string conta );
    }



}
