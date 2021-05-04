using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WinForms.Library.Validations;

namespace WinForms.Domain.Entities
{
    public class Cliente
    {
        [Required(ErrorMessage = "O campo Código do Cliente é obrigatório")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no Código do Cliente")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "O campo Código do Cliente deve conter 6 dígitos")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo {0}")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        public string EmpresaAtual { get; set; }
        public string UltimaEmpresa { get; set; }

        [Required(ErrorMessage = "O campo Profissão é obrigatório")]
        public string Profissao { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo Salário Atual")]
        public double SalarioAtual { get; set; }

        public bool Desempregado { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }
        public string AtividadesDescricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo {0}")]
        public string Celular { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo {0}")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Estado Civil é obrigatório")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "O campo Renda Familiar é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "Renda Familiar deve ser um valor positivo")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo Renda Familiar")]
        public double RendaFamiliar { get; set; }

        public Endereco Endereco { get; set; }

        public void Validate()
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

        public void ValidaInformacoes()
        {
            ValidacaoCPF cpf = new ValidacaoCPF();
            bool validaCpf = cpf.ValidarCPF(this.CPF);

            if (!validaCpf) throw new Exception("CPF inválido!");
        }
    }
}
