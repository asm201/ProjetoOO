using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    class ContaPoupanca : ContaBancaria
    {
        int cp_id { get; set; }
	    int cp_id_conta_bancaria { get; set; }

        int cp_nr_conta_poupanca { get; set; }
        float cp_valor { get; set; }
    }
}
