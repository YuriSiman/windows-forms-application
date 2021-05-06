using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WinForms.Data.Database;
using WinForms.Library.Validations;

namespace WinForms.Domain.Entities
{
    public class Cliente
    {
        [Required(ErrorMessage = "O campo Código do Cliente é obrigatório")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no Código do Cliente")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "O campo Código do Cliente deve conter 6 dígitos")]
        public string Id { get; set; }

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
        public string SalarioAtual { get; set; }

        public bool Desempregado { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }
        public string AtividadesDescricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public string DataNascimento { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo {0}")]
        public string Celular { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo {0}")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Estado Civil é obrigatório")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "O campo Renda Familiar é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "Renda Familiar deve ser um valor positivo")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Gentileza informar somente valores numéricos no campo Renda Familiar")]
        public string RendaFamiliar { get; set; }

        public Endereco Endereco { get; set; }

        #region "CRUD do Cliente"
            
        public void IncluirCliente(string conexao)
        {
            string clienteJson = SerializedCliente(this);
            DatabaseSql db = new DatabaseSql(conexao);

            if (db.status)
            {
                db.Adicionar(Id, clienteJson);
                if (!db.status)
                {
                    throw new Exception(db.mensagem);
                }
            }
            else
            {
                throw new Exception(db.mensagem);
            }
        }

        public Cliente BuscarCliente(string id, string conexao)
        {
            DatabaseSql db = new DatabaseSql(conexao);

            if (db.status)
            {
                string clienteJson = db.Buscar(id);
                return DesSerializedCliente(clienteJson);
            }
            else
            {
                throw new Exception(db.mensagem);
            }
        }

        public List<List<string>> BuscarTodosClientes(string conexao)
        {
            DatabaseSql db = new DatabaseSql(conexao);

            if (db.status)
            {
                List<string> list = new List<string>();
                list = db.BuscarTodos();
                if (db.status)
                {
                    List<List<string>> listBusca = new List<List<string>>();
                    for (int i = 0; i <= list.Count - 1; i++)
                    {
                        Cliente cliente = DesSerializedCliente(list[i]);
                        listBusca.Add(new List<string> { cliente.Id, cliente.Nome });
                    }
                    return listBusca;
                }
                else
                {
                    throw new Exception(db.mensagem);
                }
            }
            else
            {
                throw new Exception(db.mensagem);
            }
        }

        public void AlterarCliente(string conexao)
        {
            string clienteJson = SerializedCliente(this);
            DatabaseSql db = new DatabaseSql(conexao);

            if (db.status)
            {
                db.Alterar(Id, clienteJson);
                if (!db.status)
                {
                    throw new Exception(db.mensagem);
                }
            }
            else
            {
                throw new Exception(db.mensagem);
            }
        }

        public void ExcluirCliente(string conexao)
        {
            DatabaseSql db = new DatabaseSql(conexao);

            if (db.status)
            {
                db.Excluir(Id);
                if (!db.status)
                {
                    throw new Exception(db.mensagem);
                }
            }
            else
            {
                throw new Exception(db.mensagem);
            }
        }

        #endregion

        public string SerializedCliente(Cliente cliente)
        {
            return JsonConvert.SerializeObject(cliente);
        }

        public Cliente DesSerializedCliente(string json)
        {
            return JsonConvert.DeserializeObject<Cliente>(json);
        }

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
