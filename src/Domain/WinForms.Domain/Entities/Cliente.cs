using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinForms.Domain.Entities
{
    public class Cliente
    {
        [Required(ErrorMessage = "O campo Código do Cliente é obrigatório")]
        public string Codigo { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string EmpresaAtual { get; set; }
        public string UltimaEmpresa { get; set; }
        public string Profissao { get; set; }
        public double SalarioAtual { get; set; }
        public bool Desempregado { get; set; }
        public string Email { get; set; }
        public string AtividadesDescricao { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string EstadoCivil { get; set; }
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
    }
}
