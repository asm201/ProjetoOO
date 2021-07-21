using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    class ContaCorrente : ContaBancaria
    {
        int cc_id { get; set; }
        int cc_id_conta_bancaria { get; set; }

        int cc_nr_conta_corrente { get; set; }
        float cc_saldo { get; set; }
    }

}
