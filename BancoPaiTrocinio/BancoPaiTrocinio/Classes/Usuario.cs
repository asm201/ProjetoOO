using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BancoPaiTrocinio.Classes
{
    class Usuario : Contato
    {
        public int u_id { get; set; }

        [Required(ErrorMessage = "Nome do Cliente é obrigatorio")]
        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 digitos")]
        public string u_nome { get; set; }


        [Required(ErrorMessage = "CPF é obrigatorio")]
        [RegularExpression("([0-9]+)", ErrorMessage = "CPF do Cliente somente aceita valores numéricos")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF do Cliente deve ter 11 digitos")]
        public string u_cpf { get; set; }

        [Required(ErrorMessage = "RG é obrigatorio")]
        [RegularExpression("([0-9]+)", ErrorMessage = "RG do Cliente somente aceita valores numéricos")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "RG do Cliente deve ter 9 digitos")]
        public string u_rg { get; set; }

        [Required(ErrorMessage = "RG é obrigatorio")]
        public string u_senha { get; set; }
        public int u_id_cliente { get; set; }
        public int u_id_func { get; set; }
        public int u_ctt_id { get; set; }

    }
}
