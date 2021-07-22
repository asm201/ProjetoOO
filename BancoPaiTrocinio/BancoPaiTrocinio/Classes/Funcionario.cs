using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    class Funcionario : Usuario
    {
        public int f_id { get; set; }
        public int f_id_usuario { get; set; }

        public double f_salario { get; set; }
        public string f_departamento { get; set; }
        public string f_funcao { get; set; }
        public int f_id_gerente { get; set; }
        public int f_id_diretor { get; set; }
    }
}
