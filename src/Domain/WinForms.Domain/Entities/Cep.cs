using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Domain.Entities
{
    public class Cep
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public int Unidade { get; set; }
        public string IBGE { get; set; }
        public string GIA { get; set; }

        public string SerializedCliente(Cep cep)
        {
            return JsonConvert.SerializeObject(cep);
        }

        public Cep DesSerializedCep(string json)
        {
            return JsonConvert.DeserializeObject<Cep>(json);
        }
    }
}
