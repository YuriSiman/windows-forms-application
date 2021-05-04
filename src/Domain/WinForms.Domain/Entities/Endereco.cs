using System;
using System.ComponentModel.DataAnnotations;

namespace WinForms.Domain.Entities
{
    public class Endereco
    {
        [Required(ErrorMessage = "O campo Código do Endereço é obrigatório")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Estado { get; set; }
    }
}
