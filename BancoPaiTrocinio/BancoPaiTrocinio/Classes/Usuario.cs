using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    class Usuario
    {
        public int u_id { get; set; }
        public string u_nome { get; set; }
        public string u_cpf { get; set; }
        public string u_rg { get; set; }
        public string u_senha { get; set; }
        public int u_id_cliente { get; set; }
        public int u_id_func { get; set; }
        public int u_ctt_id { get; set; }

    }
}
