using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    class ContaBancaria : Cliente
    {
        int cb_id { get; set; }
	    int cb_agencia { get; set; }
        int cb_id_cliente { get; set; }

        int cb_id_conta_corrente { get; set; }

        int cb_id_conta_poupanca { get; set; }
    }
}
