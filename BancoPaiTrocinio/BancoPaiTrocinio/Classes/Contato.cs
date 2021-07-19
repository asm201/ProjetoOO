using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPaiTrocinio.Classes
{
    class Contato
    {
        public int ctt_id { get; set; }
        public int ctt_id_usuario { get; set; }

        [Required(ErrorMessage = "Numero de telefone é obrigatorio")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Numero de telefone somente aceita valores numéricos")]
        public string ctt_tel { get; set; }

        [Required(ErrorMessage = "Celular de telefone é obrigatorio")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Numero de Celular somente aceita valores numéricos")]
        public string ctt_cel { get; set; }

        [Required(ErrorMessage = "Celular de telefone é obrigatorio")]
        public string ctt_email { get; set; }

    }
}
