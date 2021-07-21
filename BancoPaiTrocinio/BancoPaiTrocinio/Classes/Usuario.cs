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

        [Required(ErrorMessage = "Senha é obrigatorio")]
        public string u_senha { get; set; }

        [Required(ErrorMessage = "CEP é obrigatorio")]
        [RegularExpression("([0-9]+)", ErrorMessage = "CEP do Cliente somente aceita valores numéricos")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP do Cliente deve ter 8 digitos")]
        public string u_cep { get; set; }

        [Required(ErrorMessage = "Logradouro é obrigatorio")]
        [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 digitos")]
        public string u_logradouro { get; set; }

        [Required(ErrorMessage = "Complemento é obrigatorio")]
        [StringLength(100, ErrorMessage = "Complemento deve ter no máximo 100 digitos")]
        public string u_complemento { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatorio")]
        [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 digitos")]
        public string u_bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatorio")]
        [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 digitos")]
        public string u_cidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatorio")]
        [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 digitos")]
        public string u_estado { get; set; }

        [Required(ErrorMessage = "Usuario é obrigatorio")]
        public string u_usario { get; set; }

        public int u_id_cliente { get; set; }
        public int u_id_func { get; set; }
        public int u_ctt_id { get; set; }

        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }

        public void ValidaComplemento()
        {
            bool validaCPF = Cls_Uteis.Valida(this.u_cpf);
            if (validaCPF == false)
            {
                throw new Exception("Cpf invalido!");
            }
        }

    }

}
