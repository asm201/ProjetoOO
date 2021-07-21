using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    class Funcionario : Usuario
    {
        int f_id { get; set; }
        int f_id_usuario { get; set; }

        float f_salario { get; set; }
        string f_departamento { get; set; }
        string f_funcao { get; set; }
        int f_id_gerente { get; set; }
        int f_id_diretor { get; set; }
    }
}
