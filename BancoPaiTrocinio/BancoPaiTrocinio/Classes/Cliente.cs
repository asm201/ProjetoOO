using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    public abstract class Cliente : Usuario
    {
        public int c_id { get; set; }
        public int c_id_usuario { get; set; }

        public string c_profissao { get; set; }
    }
}
